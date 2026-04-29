// REST API with Rate Limiting
using Microsoft.AspNetCore.RateLimiting;
using Microsoft.OpenApi.Models;
using System.Threading.RateLimiting;

var builder = WebApplication.CreateBuilder(args);

// ------------------ RATE LIMITING ------------------
builder.Services.AddRateLimiter(options =>
{
    options.AddFixedWindowLimiter("fixed", opt =>
    {
        opt.PermitLimit = 5; // max 5 requests
        opt.Window = TimeSpan.FromSeconds(10); // per 10 seconds
        opt.QueueProcessingOrder = QueueProcessingOrder.OldestFirst;
        opt.QueueLimit = 2; // extra queued requests
    });

    options.RejectionStatusCode = StatusCodes.Status429TooManyRequests;
});

// ------------------ SWAGGER ------------------
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Rate Limited API",
        Version = "v1",
        Description = "Simple REST API with Rate Limiting"
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

// Enable Rate Limiting
app.UseRateLimiter();

// ------------------ SAMPLE DATA ------------------
var students = new List<Student>
{
    new Student { Id = 1, Name = "Ishita", Age = 20 },
    new Student { Id = 2, Name = "Rahul", Age = 22 }
};

// ------------------ ENDPOINTS ------------------

// GET all students (rate limited)
app.MapGet("/students", () => students)
   .RequireRateLimiting("fixed");

// GET student by ID
app.MapGet("/students/{id}", (int id) =>
{
    var student = students.FirstOrDefault(s => s.Id == id);
    return student is not null ? Results.Ok(student) : Results.NotFound();
})
.RequireRateLimiting("fixed");

// POST create student
app.MapPost("/students", (Student student) =>
{
    student.Id = students.Max(s => s.Id) + 1;
    students.Add(student);
    return Results.Created($"/students/{student.Id}", student);
})
.RequireRateLimiting("fixed");

// PUT update student
app.MapPut("/students/{id}", (int id, Student input) =>
{
    var student = students.FirstOrDefault(s => s.Id == id);
    if (student is null) return Results.NotFound();

    student.Name = input.Name;
    student.Age = input.Age;

    return Results.Ok(student);
})
.RequireRateLimiting("fixed");

// DELETE student
app.MapDelete("/students/{id}", (int id) =>
{
    var student = students.FirstOrDefault(s => s.Id == id);
    if (student is null) return Results.NotFound();

    students.Remove(student);
    return Results.Ok();
})
.RequireRateLimiting("fixed");

app.Run();

// ------------------ MODEL ------------------
public class Student
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public int Age { get; set; }
}
