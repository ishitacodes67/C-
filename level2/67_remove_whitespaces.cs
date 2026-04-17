// Program to remove white spaces from string 
using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();
        string trimmedString = input.Trim();
        Console.WriteLine("String after removing white spaces: " + trimmedString);
    }
}
