// Program to split string into words 
using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();
        string[] words = SplitString(input);
        Console.WriteLine("The words in the string are:");
        foreach (string word in words)
        {
            Console.WriteLine(word);
        }
    }

    static string[] SplitString(string str)
    {
        return str.Split(' ');
    }
}

