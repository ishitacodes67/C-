// Program to demonstrate string formatting 
using System;
class Program
{
    static void Main()
    {
        string name = "Alice";
        int age = 30;
        double height = 5.6;

        // Using string.Format
        string formattedString1 = string.Format("Name: {0}, Age: {1}, Height: {2}", name, age, height);
        Console.WriteLine(formattedString1);

        // Using string interpolation
        string formattedString2 = $"Name: {name}, Age: {age}, Height: {height}";
        Console.WriteLine(formattedString2);

        // Using composite formatting with alignment and format specifiers
        string formattedString3 = string.Format("Name: {0,-10} Age: {1:D3} Height: {2:F2}", name, age, height);
        Console.WriteLine(formattedString3);
    }
}   
