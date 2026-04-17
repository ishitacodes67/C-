// Program to count words in a string
using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();
        int wordCount = CountWords(input);
        Console.WriteLine("Number of words in the string: " + wordCount);
    }

    static int CountWords(string str)
    {
        if (string.IsNullOrWhiteSpace(str))
        {
            return 0;
        }
        string[] words = str.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
        return words.Length;
    }
}