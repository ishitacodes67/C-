// REST API with Swagger Documentation
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Student API",
        Version = "v1",
        Description = "Simple REST API with Swagger Documentation"
    });
});

var app = builder.Build();

// Enable Swagger middleware
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Sample in-memory data
var students = new List<Student>
{
    new Student { Id = 1, Name = "Ishita", Age = 20 },
    new Student { Id = 2, Name = "Rahul", Age = 22 }
};

// GET all students
app.MapGet("/students", () => students)
    .WithName("GetStudents")
    .WithOpenApi();

// GET student by ID
app.MapGet("/students/{id}", (int id) =>
{
    var student = students.FirstOrDefault(s => s.Id == id);
    return student is not null ? Results.Ok(student) : Results.NotFound();
})
.WithName("GetStudentById")
.WithOpenApi();

// POST add new student
app.MapPost("/students", (Student student) =>
{
    student.Id = students.Max(s => s.Id) + 1;
    students.Add(student);
    return Results.Created($"/students/{student.Id}", student);
})
.WithName("CreateStudent")
.WithOpenApi();

// PUT update student
app.MapPut("/students/{id}", (int id, Student updatedStudent) =>
{
    var student = students.FirstOrDefault(s => s.Id == id);

    if (student is null)
        return Results.NotFound();

    student.Name = updatedStudent.Name;
    student.Age = updatedStudent.Age;

    return Results.Ok(student);
})
.WithName("UpdateStudent")
.WithOpenApi();

// DELETE student
app.MapDelete("/students/{id}", (int id) =>
{
    var student = students.FirstOrDefault(s => s.Id == id);

    if (student is null)
        return Results.NotFound();

    students.Remove(student);
    return Results.Ok();
})
.WithName("DeleteStudent")
.WithOpenApi();

app.Run();

// Model class
public class Student
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public int Age { get; set; }
}

