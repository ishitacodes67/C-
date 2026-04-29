// Program to demonstrate collections (List)
using System;
using System.Collections.Generic; // Importing the Collections.Generic namespace for List
class Program   
{
    static void Main()
    {
        // Creating a List to store integers
        List<int> myList = new List<int>();
        
        // Adding elements to the List
        myList.Add(10);
        myList.Add(20);
        myList.Add(30);
        
        // Displaying the contents of the List
        Console.WriteLine("Contents of the List:");
        foreach (var item in myList)
        {
            Console.WriteLine(item);
        }
        
        // Accessing specific elements by index
        Console.WriteLine($"\nElement at index 0: {myList[0]}");
        Console.WriteLine($"Element at index 1: {myList[1]}");
        Console.WriteLine($"Element at index 2: {myList[2]}");
        
        // Removing an element from the List
        myList.Remove(20);
        
        // Displaying the contents after removal
        Console.WriteLine("\nContents of the List after removing 20:");
        foreach (var item in myList)
        {
            Console.WriteLine(item);
        }
    }
}
