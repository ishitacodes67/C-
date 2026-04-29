// Program to demonstrate try-catch-finally
using System;
class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"You entered: {number}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            Console.WriteLine($"Error details: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("This block will always execute, regardless of exceptions.");
        }
    }
}
