//  Program to demonstrate string interpolation
using System;
class Program
{
    static void Main()
    {
        string name = "Alice";
        int age = 30;
        string profession = "Engineer";

        // Using string interpolation to create a formatted string
        string message = $"Name: {name}, Age: {age}, Profession: {profession}";

        // Display the message
        Console.WriteLine(message);
    }
}