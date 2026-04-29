// Program to demonstrate LINQ (GroupBy)
using System;
using System.Collections.Generic; // Importing the Collections.Generic namespace for List
using System.Linq; // Importing the Linq namespace for LINQ operations
class Program   
{
    static void Main()
    {
        // Demonstrating LINQ with GroupBy
        List<string> fruits = new List<string> { "Apple", "Banana", "Cherry", "Apple", "Banana", "Cherry", "Apple" };
        
        // Using GroupBy to group fruits by their name
        var groupedFruits = fruits.GroupBy(f => f);
        
        Console.WriteLine("Grouped fruits:");
        foreach (var group in groupedFruits)
        {
            Console.WriteLine($"{group.Key}: {group.Count()}");
        }
    }
}
