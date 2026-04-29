// REST API with Entity Framework Core
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

// ------------------ BUILDER ------------------
var builder = WebApplication.CreateBuilder(args);

// Add DbContext (SQL Server)
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer("Server=.;Database=StudentDB;Trusted_Connection=True;TrustServerCertificate=True;"));

// Add Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Student API (EF Core)",
        Version = "v1",
        Description = "Simple REST API using Entity Framework Core"
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

// GET all students
app.MapGet("/students", async (AppDbContext db) =>
    await db.Students.ToListAsync());

// GET student by ID
app.MapGet("/students/{id}", async (int id, AppDbContext db) =>
{
    var student = await db.Students.FindAsync(id);
    return student is not null ? Results.Ok(student) : Results.NotFound();
});

// POST create student
app.MapPost("/students", async (Student student, AppDbContext db) =>
{
    db.Students.Add(student);
    await db.SaveChangesAsync();
    return Results.Created($"/students/{student.Id}", student);
});

// PUT update student
app.MapPut("/students/{id}", async (int id, Student input, AppDbContext db) =>
{
    var student = await db.Students.FindAsync(id);
    if (student is null) return Results.NotFound();

    student.Name = input.Name;
    student.Age = input.Age;

    await db.SaveChangesAsync();
    return Results.Ok(student);
});

// DELETE student
app.MapDelete("/students/{id}", async (int id, AppDbContext db) =>
{
    var student = await db.Students.FindAsync(id);
    if (student is null) return Results.NotFound();

    db.Students.Remove(student);
    await db.SaveChangesAsync();
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
