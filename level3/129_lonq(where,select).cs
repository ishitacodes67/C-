// Program to demonstrate LINQ (Where, Select)
using System;
using System.Collections.Generic; // Importing the Collections.Generic namespace for List
using System.Linq; // Importing the Linq namespace for LINQ operations
class Program   
{
    static void Main()
    {
        // Demonstrating LINQ with Where and Select
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        
        // Using Where to filter even numbers
        var evenNumbers = numbers.Where(n => n % 2 == 0);
        
        Console.WriteLine("Even numbers:");
        foreach (var num in evenNumbers)
        {
            Console.WriteLine(num);
        }
        
        // Using Select to square the numbers
        var squaredNumbers = numbers.Select(n => n * n);
        
        Console.WriteLine("\nSquared numbers:");
        foreach (var num in squaredNumbers)
        {
            Console.WriteLine(num);
        }
    }
}
