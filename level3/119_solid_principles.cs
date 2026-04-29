// Program to demonstrate SOLID principles (examples)
using System;
// Single Responsibility Principle (SRP)
class User
{
    public string Name { get; set; }
    public string Email { get; set; }
}
class UserRepository
{
    public void Save(User user)
    {
        // Code to save user to database
        Console.WriteLine($"User {user.Name} saved to database.");
    }
}
// Open/Closed Principle (OCP)
abstract class Shape
{
    public abstract double Area();
}
class Circle : Shape
{
    public double Radius { get; set; }
    public override double Area()
    {
        return Math.PI * Radius * Radius;
    }
}
class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }
    public override double Area()
    {
        return Width * Height;
    }
}
// Liskov Substitution Principle (LSP)
class Bird
{
    public virtual void Fly()
    {
        Console.WriteLine("Flying");
    }
}
class Sparrow : Bird
{
    public override void Fly()
    {
        Console.WriteLine("Sparrow flying");
    }
}
class Ostrich : Bird
{
    public override void Fly()
    {
        throw new NotSupportedException("Ostriches cannot fly");
    }
}
// Interface Segregation Principle (ISP)
interface IWorker
{
    void Work();
}
interface IManager
{
    void Manage();
}
class Employee : IWorker
{
    public void Work()
    {
        Console.WriteLine("Employee working");
    }
}
class Manager : IWorker, IManager
{
    public void Work()
    {
        Console.WriteLine("Manager working");
    }

    public void Manage()
    {
        Console.WriteLine("Manager managing");
    }
}
// Dependency Inversion Principle (DIP)
interface ILogger
{
    void Log(string message);
}
class ConsoleLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine($"Log: {message}");
    }
}
class Application
{
    private readonly ILogger _logger;
    public Application(ILogger logger)
    {
        _logger = logger;
    }
    public void Run()
    {
        _logger.Log("Application is running");
    }
}
class Program
{
    static void Main()
    {
        // SRP
        User user = new User { Name = "Alice", Email = "alice@example.com" };
        UserRepository repo = new UserRepository();
        repo.Save(user);

        // OCP
        Shape circle = new Circle { Radius = 5 };
        Shape rectangle = new Rectangle { Width = 10, Height = 5 };
        Console.WriteLine($"Circle area: {circle.Area()}");
        Console.WriteLine($"Rectangle area: {rectangle.Area()}");

        // LSP
        Bird sparrow = new Sparrow();
        Bird ostrich = new Ostrich();
        sparrow.Fly();
        ostrich.Fly();

        // ISP
        IWorker employee = new Employee();
        IManager manager = new Manager();
        employee.Work();
        manager.Work();
        manager.Manage();

        // DIP
        ILogger logger = new ConsoleLogger();
        Application app = new Application(logger);
        app.Run();
    }
}
