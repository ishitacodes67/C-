// Program to demonstrate async and await
using System;
using System.Threading.Tasks;
class Program
{
    static async Task Main()
    {
        Console.WriteLine("Starting async operation...");
        string result = await LongRunningOperation();
        Console.WriteLine($"Result: {result}");
    }

    static async Task<string> LongRunningOperation()
    {
        // Simulate a long-running operation
        await Task.Delay(2000); // Wait for 2 seconds
        return "Operation Completed!";
    }
}
