// Dockerize .NET Application 
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Docker .NET API",
        Version = "v1"
    });
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Sample endpoints
app.MapGet("/", () => "Hello from Dockerized API 🚀");

app.MapGet("/students", () =>
{
    return new[]
    {
        new { Id = 1, Name = "Ishita", Age = 20 },
        new { Id = 2, Name = "Rahul", Age = 22 }
    };
});

app.Run();

