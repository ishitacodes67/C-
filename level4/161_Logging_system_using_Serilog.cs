// Logging system using Serilog
using System;
using Serilog;
namespace LoggingSystemUsingSerilog
{
    class Program
    {
        static void Main(string[] args)
        {
            // Configure Serilog
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.Console()
                .WriteTo.File("logs/log-.txt", rollingInterval: RollingInterval.Day)
                .CreateLogger();

            // Log some messages
            Log.Information("Application started.");
            Log.Debug("This is a debug message.");
            Log.Warning("This is a warning message.");
            Log.Error("This is an error message.");

            try
            {
                // Simulate an exception
                throw new InvalidOperationException("Something went wrong!");
            }
            catch (Exception ex)
            {
                Log.Error(ex, "An exception occurred.");
            }

            Log.Information("Application ended.");
        }
    }
}
