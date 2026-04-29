// Program to demonstrate dependency injection (basic) 
using System;
// Service interface
interface IMessageService
{
    void SendMessage(string message);
}
// Service implementation
class EmailService : IMessageService
{
    public void SendMessage(string message)
    {
        Console.WriteLine($"Email sent: {message}");
    }
}
// Client class that depends on the service
class Notification
{
    private readonly IMessageService _messageService;
    // Constructor injection
    public Notification(IMessageService messageService)
    {
        _messageService = messageService;
    }
    public void Notify(string message)
    {
        _messageService.SendMessage(message);
    }
}
class Program
{
    static void Main()
    {
        // Create the service instance
        IMessageService emailService = new EmailService();
        // Inject the service into the client
        Notification notification = new Notification(emailService);
        // Use the client to send a notification
        notification.Notify("Hello, Dependency Injection!");
    }
}
