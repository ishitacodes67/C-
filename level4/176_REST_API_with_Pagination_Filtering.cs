// REST API with Pagination and Filtering
// This code demonstrates how to create a REST API with pagination and filtering capabilities using ASP.NET Core.
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// ------------------ SWAGGER ------------------
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Student API with Pagination & Filtering",
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

// ------------------ SAMPLE DATA ------------------
var students = new List<Student>
{
    new Student { Id = 1, Name = "Ishita", Age = 20 },
    new Student { Id = 2, Name = "Rahul", Age = 22 },
    new Student { Id = 3, Name = "Amit", Age = 21 },
    new Student { Id = 4, Name = "Neha", Age = 23 },
    new Student { Id = 5, Name = "Riya", Age = 20 },
    new Student { Id = 6, Name = "Karan", Age = 24 },
    new Student { Id = 7, Name = "Sneha", Age = 22 },
    new Student { Id = 8, Name = "Arjun", Age = 21 }
};

// ------------------ ENDPOINT ------------------

// GET with Pagination + Filtering
// Example:
// /students?page=1&pageSize=3&name=ri&minAge=20&maxAge=22
app.MapGet("/students", (
    int page = 1,
    int pageSize = 3,
    string? name = null,
    int? minAge = null,
    int? maxAge = null
) =>
{
    var query = students.AsQueryable();

    // -------- FILTERING --------
    if (!string.IsNullOrWhiteSpace(name))
    {
        query = query.Where(s => s.Name.ToLower().Contains(name.ToLower()));
    }

    if (minAge.HasValue)
    {
        query = query.Where(s => s.Age >= minAge.Value);
    }

    if (maxAge.HasValue)
    {
        query = query.Where(s => s.Age <= maxAge.Value);
    }

    // -------- PAGINATION --------
    var totalRecords = query.Count();

    var pagedData = query
        .Skip((page - 1) * pageSize)
        .Take(pageSize)
        .ToList();

    return Results.Ok(new
    {
        Page = page,
        PageSize = pageSize,
        TotalRecords = totalRecords,
        Data = pagedData
    });
});

app.Run();

// ------------------ MODEL ------------------
public class Student
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public int Age { get; set; }
}
