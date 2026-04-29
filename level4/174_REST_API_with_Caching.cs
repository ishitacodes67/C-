// REST API with Caching (Redis) 
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Microsoft.Extensions.Caching.Distributed;
using System.Text.Json;

// ------------------ BUILDER ------------------
var builder = WebApplication.CreateBuilder(args);

// SQL Server DbContext
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer("Server=.;Database=StudentDB;Trusted_Connection=True;TrustServerCertificate=True;"));

// Redis Cache (make sure Redis is running)
builder.Services.AddStackExchangeRedisCache(options =>
{
    options.Configuration = "localhost:6379";
    options.InstanceName = "StudentAPI_";
});

// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Student API with Redis Cache",
        Version = "v1"
    });
});

var app = builder.Build();

// ------------------ MIDDLEWARE ------------------
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// ------------------ ENDPOINTS ------------------

// GET all students (with Redis cache)
app.MapGet("/students", async (AppDbContext db, IDistributedCache cache) =>
{
    string cacheKey = "students_list";

    var cachedData = await cache.GetStringAsync(cacheKey);

    if (!string.IsNullOrEmpty(cachedData))
    {
        var studentsFromCache = JsonSerializer.Deserialize<List<Student>>(cachedData);
        return Results.Ok(studentsFromCache);
    }

    var students = await db.Students.ToListAsync();

    var options = new DistributedCacheEntryOptions
    {
        AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(5)
    };

    await cache.SetStringAsync(cacheKey, JsonSerializer.Serialize(students), options);

    return Results.Ok(students);
});

// GET student by ID (with cache)
app.MapGet("/students/{id}", async (int id, AppDbContext db, IDistributedCache cache) =>
{
    string cacheKey = $"student_{id}";

    var cachedData = await cache.GetStringAsync(cacheKey);

    if (!string.IsNullOrEmpty(cachedData))
    {
        var studentFromCache = JsonSerializer.Deserialize<Student>(cachedData);
        return Results.Ok(studentFromCache);
    }

    var student = await db.Students.FindAsync(id);

    if (student is null) return Results.NotFound();

    var options = new DistributedCacheEntryOptions
    {
        AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(5)
    };

    await cache.SetStringAsync(cacheKey, JsonSerializer.Serialize(student), options);

    return Results.Ok(student);
});

// POST create student (invalidate cache)
app.MapPost("/students", async (Student student, AppDbContext db, IDistributedCache cache) =>
{
    db.Students.Add(student);
    await db.SaveChangesAsync();

    await cache.RemoveAsync("students_list");

    return Results.Created($"/students/{student.Id}", student);
});

// PUT update student (invalidate cache)
app.MapPut("/students/{id}", async (int id, Student input, AppDbContext db, IDistributedCache cache) =>
{
    var student = await db.Students.FindAsync(id);
    if (student is null) return Results.NotFound();

    student.Name = input.Name;
    student.Age = input.Age;

    await db.SaveChangesAsync();

    await cache.RemoveAsync("students_list");
    await cache.RemoveAsync($"student_{id}");

    return Results.Ok(student);
});

// DELETE student (invalidate cache)
app.MapDelete("/students/{id}", async (int id, AppDbContext db, IDistributedCache cache) =>
{
    var student = await db.Students.FindAsync(id);
    if (student is null) return Results.NotFound();

    db.Students.Remove(student);
    await db.SaveChangesAsync();

    await cache.RemoveAsync("students_list");
    await cache.RemoveAsync($"student_{id}");

    return Results.Ok();
});

app.Run();

// ------------------ MODEL ------------------
public class Student
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public int Age { get; set; }
}

// ------------------ DB CONTEXT ------------------
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Student> Students => Set<Student>();
}
