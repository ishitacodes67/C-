// Program to demonstrate LINQ (Aggregate)
using System;
using System.Collections.Generic; // Importing the Collections.Generic namespace for List
using System.Linq; // Importing the Linq namespace for LINQ operations
class Program   
{
    static void Main()
    {
        // Demonstrating LINQ with Aggregate
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
        
        // Using Aggregate to calculate the product of all numbers
        int product = numbers.Aggregate((acc, n) => acc * n);
        
        Console.WriteLine($"Product of all numbers: {product}");
    }
}
