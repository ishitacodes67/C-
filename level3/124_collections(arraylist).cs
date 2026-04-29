// Program to demonstrate collections (ArrayList)
using System;
using System.Collections; // Importing the Collections namespace for ArrayList
class Program   
{
    static void Main()
    {
        // Creating an ArrayList to store different types of data
        ArrayList myList = new ArrayList();
        
        // Adding elements to the ArrayList
        myList.Add(42); // Adding an integer
        myList.Add("Hello, World!"); // Adding a string
        myList.Add(3.14); // Adding a double
        
        // Displaying the contents of the ArrayList
        Console.WriteLine("Contents of the ArrayList:");
        foreach (var item in myList)
        {
            Console.WriteLine(item);
        }
        
        // Accessing specific elements by index
        Console.WriteLine($"\nElement at index 0: {myList[0]}");
        Console.WriteLine($"Element at index 1: {myList[1]}");
        Console.WriteLine($"Element at index 2: {myList[2]}");
        
        // Removing an element from the ArrayList
        myList.Remove(3.14);
        
        // Displaying the contents after removal
        Console.WriteLine("\nContents of the ArrayList after removing 3.14:");
        foreach (var item in myList)
        {
            Console.WriteLine(item);
        }
    }
}
