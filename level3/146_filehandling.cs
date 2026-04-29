// Program to demonstrate file handling 
using System;
using System.IO;

class FileHandlingDemo
{
    static void Main(string[] args)
    {
        string filePath = "sample.txt";

        // 1. Create and Write to a file
        Console.WriteLine("Creating and writing to file...");
        File.WriteAllText(filePath, "Hello, this is the first line.\n");

        // 2. Append data to the file
        Console.WriteLine("Appending data to file...");
        File.AppendAllText(filePath, "This is an appended line.\n");

        // 3. Read from the file
        Console.WriteLine("\nReading file content:\n");
        string content = File.ReadAllText(filePath);
        Console.WriteLine(content);

        // 4. Check if file exists
        if (File.Exists(filePath))
        {
            Console.WriteLine("\nFile exists at: " + Path.GetFullPath(filePath));
        }
        else
        {
            Console.WriteLine("File does not exist.");
        }
    }
}


