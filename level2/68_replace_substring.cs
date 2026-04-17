// Program to replace substring in string 
using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();
        Console.WriteLine("Enter the substring to be replaced:");
        string oldSubstring = Console.ReadLine();
        Console.WriteLine("Enter the new substring:");
        string newSubstring = Console.ReadLine();
        string result = input.Replace(oldSubstring, newSubstring);
        Console.WriteLine("String after replacement: " + result);
    }
}
