// Dependency Injection in Console App 
using System;
namespace DependencyInjection
{
    // Interface for a service
    public interface IGreetingService
    {
        void Greet(string name);
    }

    // Implementation of the service
    public class GreetingService : IGreetingService
    {
        public void Greet(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }

    // Main application class that depends on the service
    public class Application
    {
        private readonly IGreetingService _greetingService;

        // Constructor injection
        public Application(IGreetingService greetingService)
        {
            _greetingService = greetingService;
        }

        public void Run()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            _greetingService.Greet(name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Manually create the service and inject it into the application
            IGreetingService greetingService = new GreetingService();
            Application app = new Application(greetingService);
            app.Run();
        }
    }
}
