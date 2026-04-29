// Background Worker using Hosted Services 
using Microsoft.OpenApi.Models;
using Microsoft.Extensions.Hosting;

// ------------------ BUILDER ------------------
var builder = WebApplication.CreateBuilder(args);

// Register Background Worker
builder.Services.AddHostedService<MyBackgroundWorker>();

// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Background Worker API",
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

// ------------------ ENDPOINT ------------------

// Simple endpoint to check API
app.MapGet("/", () => "API is running. Background worker is active.");

// Endpoint to see last run time
app.MapGet("/status", () =>
{
    return Results.Ok(new
    {
        LastRunTime = MyBackgroundWorker.LastRunTime
    });
});

app.Run();

// ------------------ BACKGROUND WORKER ------------------
public class MyBackgroundWorker : BackgroundService
{
    public static DateTime LastRunTime { get; private set; }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            LastRunTime = DateTime.Now;

            Console.WriteLine($"Background task running at: {LastRunTime}");

            // Simulate work (runs every 10 seconds)
            await Task.Delay(TimeSpan.FromSeconds(10), stoppingToken);
        }
    }
}
