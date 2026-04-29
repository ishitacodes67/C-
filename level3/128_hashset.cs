// Program to demonstrate HashSet
using System;
using System.Collections.Generic; // Importing the Collections.Generic namespace for HashSet
class Program
{
    static void Main()
    {
        // Demonstrating HashSet
        HashSet<string> myHashSet = new HashSet<string>();
        myHashSet.Add("Apple");
        myHashSet.Add("Banana");
        myHashSet.Add("Cherry");
        myHashSet.Add("Apple"); // Duplicate, will not be added
        
        Console.WriteLine("Contents of the HashSet:");
        foreach (var item in myHashSet)
        {
            Console.WriteLine(item);
        }
        
        Console.WriteLine($"\nDoes the HashSet contain 'Banana'? {myHashSet.Contains("Banana")}");
        
        myHashSet.Remove("Banana");
        Console.WriteLine($"\nAfter removing 'Banana', does the HashSet contain 'Banana'? {myHashSet.Contains("Banana")}");
    }
}
