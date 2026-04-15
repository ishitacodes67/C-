// Program to demonstrate DateTime class 
using System;
class Program
{
    static void Main()
    {
        // Get the current date and time
        DateTime now = DateTime.Now;
        Console.WriteLine($"Current date and time: {now}");

        // Create a specific date and time
        DateTime specificDate = new DateTime(2022, 12, 25, 10, 30, 0);
        Console.WriteLine($"Specific date and time: {specificDate}");

        // Add days to the current date
        DateTime futureDate = now.AddDays(7);
        Console.WriteLine($"Date after adding 7 days: {futureDate}");

        // Subtract days from the current date
        DateTime pastDate = now.AddDays(-7);
        Console.WriteLine($"Date after subtracting 7 days: {pastDate}");
    }
}