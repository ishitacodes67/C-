// Program to demonstrate throwing exceptions 
using System;
class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Enter a positive number:");
            int number = int.Parse(Console.ReadLine());
            if (number < 0)
            {
                throw new ArgumentException("Negative numbers are not allowed.");
            }
            Console.WriteLine($"You entered: {number}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}

