// Program to demonstrate Dictionary 
using System;
using System.Collections.Generic; // Importing the Collections.Generic namespace for Dictionary
class Program   
{
    static void Main()
    {
        // Creating a Dictionary to store key-value pairs
        Dictionary<string, int> myDictionary = new Dictionary<string, int>();
        
        // Adding key-value pairs to the Dictionary
        myDictionary.Add("Alice", 30);
        myDictionary.Add("Bob", 25);
        myDictionary.Add("Charlie", 35);
        
        // Displaying the contents of the Dictionary
        Console.WriteLine("Contents of the Dictionary:");
        foreach (var kvp in myDictionary)
        {
            Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
        }
        
        // Accessing specific values by key
        Console.WriteLine($"\nValue for key 'Alice': {myDictionary["Alice"]}");
        Console.WriteLine($"Value for key 'Bob': {myDictionary["Bob"]}");
        
        // Removing a key-value pair from the Dictionary
        myDictionary.Remove("Charlie");
        
        // Displaying the contents after removal
        Console.WriteLine("\nContents of the Dictionary after removing 'Charlie':");
        foreach (var kvp in myDictionary)
        {
            Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
        }
    }
}
