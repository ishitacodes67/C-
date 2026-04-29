// Program to demonstrate extension methods
using System;
// Define an extension method for the string class
static class StringExtensions
{
    public static string Reverse(this string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}
class Program
{
    static void Main()
    {
        string original = "Hello, World!";
        string reversed = original.Reverse(); // Using the extension method

        Console.WriteLine($"Original: {original}");
        Console.WriteLine($"Reversed: {reversed}");
    }
}
