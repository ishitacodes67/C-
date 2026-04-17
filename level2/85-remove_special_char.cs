// Program to remove special characters from string
using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();
        string result = RemoveSpecialCharacters(input);
        Console.WriteLine("The string after removing special characters is: {0}", result);
    }

    static string RemoveSpecialCharacters(string str)
    {
        // Define a set of special characters to remove
        char[] specialChars = { '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '+', '=', '[', ']', '{', '}', '|', '\\', ':', ';', '"', '\'', '<', '>', ',', '.', '?', '/' };

        // Remove special characters from the string
        foreach (char c in specialChars)
        {
            str = str.Replace(c.ToString(), "");
        }

        return str;
    }
}
