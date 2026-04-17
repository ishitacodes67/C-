// Program to demonstrate immutability of strings
using System;
class Program
{
    static void Main()
    {
        string str1 = "Hello";
        string str2 = str1; // str2 references the same string as str1

        Console.WriteLine("Before modification:");
        Console.WriteLine("str1: " + str1); // Output: Hello
        Console.WriteLine("str2: " + str2); // Output: Hello

        // Modifying str1 creates a new string, str2 remains unchanged
        str1 += " World";

        Console.WriteLine("\nAfter modification:");
        Console.WriteLine("str1: " + str1); // Output: Hello World
        Console.WriteLine("str2: " + str2); // Output: Hello
    }
}   