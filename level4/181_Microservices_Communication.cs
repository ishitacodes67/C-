// Microservices Communication (Basic)
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add HttpClient (for inter-service communication)
builder.Services.AddHttpClient();

// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Microservices Communication API",
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

// =====================================================
// 🔵 SERVICE B (Provider Service)
// =====================================================
// This simulates another microservice returning data

app.MapGet("/service-b/data", () =>
{
    return Results.Ok(new
    {
        Message = "Hello from Service B",
        Time = DateTime.Now
    });
});

// =====================================================
// 🟢 SERVICE A (Consumer Service)
// =====================================================
// This calls Service B using HttpClient

app.MapGet("/service-a/get-data", async (IHttpClientFactory httpClientFactory) =>
{
    var client = httpClientFactory.CreateClient();

    // Calling Service B endpoint
    var response = await client.GetAsync("https://localhost:5001/service-b/data");

    if (!response.IsSuccessStatusCode)
        return Results.StatusCode((int)response.StatusCode);

    var data = await response.Content.ReadAsStringAsync();

    return Results.Ok(new
    {
        Message = "Response from Service B via Service A",
        Data = data
    });
});

app.Run();
