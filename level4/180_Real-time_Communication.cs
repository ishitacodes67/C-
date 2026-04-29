// Real-time Communication using SignalR
using Microsoft.AspNetCore.SignalR;
using Microsoft.OpenApi.Models;

// ------------------ BUILDER ------------------
var builder = WebApplication.CreateBuilder(args);

// Add SignalR
builder.Services.AddSignalR();

// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "SignalR Real-Time API",
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

// ------------------ SIGNALR HUB ------------------
app.MapHub<ChatHub>("/chatHub");

// ------------------ API ENDPOINT ------------------

// Send message to all connected clients
app.MapPost("/send", async (string message, IHubContext<ChatHub> hubContext) =>
{
    await hubContext.Clients.All.SendAsync("ReceiveMessage", message);

    return Results.Ok(new
    {
        Status = "Message sent to all clients",
        Data = message
    });
});

app.Run();

// ------------------ HUB CLASS ------------------
public class ChatHub : Hub
{
    // Optional: when a client connects
    public override async Task OnConnectedAsync()
    {
        Console.WriteLine("Client connected: " + Context.ConnectionId);
        await base.OnConnectedAsync();
    }

    // Optional: when a client disconnects
    public override async Task OnDisconnectedAsync(Exception? exception)
    {
        Console.WriteLine("Client disconnected: " + Context.ConnectionId);
        await base.OnDisconnectedAsync(exception);
    }
}
