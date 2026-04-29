// Configuration management using appsettings.json 
using System;
using Microsoft.Extensions.Configuration;
namespace ConfigurationManagementUsingAppSettings
{
    class Program
    {
        static void Main(string[] args)
        {
            // Build configuration from appsettings.json
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            // Read configuration values
            var appName = configuration["Application:Name"];
            var appVersion = configuration["Application:Version"];
            var loggingLevel = configuration["Logging:LogLevel:Default"];

            // Display configuration values
            Console.WriteLine($"Application Name: {appName}");
            Console.WriteLine($"Application Version: {appVersion}");
            Console.WriteLine($"Logging Level: {loggingLevel}");
        }
    }
}

