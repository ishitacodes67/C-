// Program to demonstrate exception handling 
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
            Console.WriteLine("Input was not a valid number. Please enter a valid integer.");
            Console.WriteLine($"Error details: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An unexpected error occurred.");
            Console.WriteLine($"Error details: {ex.Message}");
        }
    }
}
