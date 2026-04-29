// Message Queue using RabbitMQ (Basic) 
using Microsoft.OpenApi.Models;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;

// ------------------ BUILDER ------------------
var builder = WebApplication.CreateBuilder(args);

// Register RabbitMQ Service
builder.Services.AddSingleton<RabbitMqService>();

// Register Background Consumer
builder.Services.AddHostedService<RabbitMqConsumer>();

// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "RabbitMQ API",
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

// Send message to queue
app.MapPost("/send", (string message, RabbitMqService mq) =>
{
    mq.SendMessage(message);
    return Results.Ok(new { Message = "Message sent to RabbitMQ", Data = message });
});

app.Run();


// ------------------ RABBITMQ SERVICE (PRODUCER) ------------------
public class RabbitMqService
{
    private readonly IConnection _connection;
    private readonly IModel _channel;
    private readonly string _queueName = "demo_queue";

    public RabbitMqService()
    {
        var factory = new ConnectionFactory()
        {
            HostName = "localhost"
        };

        _connection = factory.CreateConnection();
        _channel = _connection.CreateModel();

        _channel.QueueDeclare(
            queue: _queueName,
            durable: false,
            exclusive: false,
            autoDelete: false,
            arguments: null
        );
    }

    public void SendMessage(string message)
    {
        var body = Encoding.UTF8.GetBytes(message);

        _channel.BasicPublish(
            exchange: "",
            routingKey: _queueName,
            basicProperties: null,
            body: body
        );

        Console.WriteLine($"[x] Sent: {message}");
    }
}


// ------------------ BACKGROUND CONSUMER ------------------
public class RabbitMqConsumer : BackgroundService
{
    private readonly IConnection _connection;
    private readonly IModel _channel;
    private readonly string _queueName = "demo_queue";

    public RabbitMqConsumer()
    {
        var factory = new ConnectionFactory()
        {
            HostName = "localhost"
        };

        _connection = factory.CreateConnection();
        _channel = _connection.CreateModel();

        _channel.QueueDeclare(
            queue: _queueName,
            durable: false,
            exclusive: false,
            autoDelete: false,
            arguments: null
        );
    }

    protected override Task ExecuteAsync(CancellationToken stoppingToken)
    {
        var consumer = new EventingBasicConsumer(_channel);

        consumer.Received += (model, ea) =>
        {
            var body = ea.Body.ToArray();
            var message = Encoding.UTF8.GetString(body);

            Console.WriteLine($"[x] Received: {message}");
        };

        _channel.BasicConsume(
            queue: _queueName,
            autoAck: true,
            consumer: consumer
        );

        return Task.CompletedTask;
    }
}
