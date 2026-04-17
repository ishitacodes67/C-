// Program to demonstrate regular expressions
using System;
using System.Text.RegularExpressions;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();

        // Example 1: Match a simple pattern
        string pattern1 = @"^\d{3}-\d{2}-\d{4}$";
        if (Regex.IsMatch(input, pattern1))
        {
            Console.WriteLine("The string matches the SSN pattern.");
        }
        else
        {
            Console.WriteLine("The string does not match the SSN pattern.");
        }

        // Example 2: Find all matches
        string pattern2 = @"\b\w+@\w+\.\w+\b";
        MatchCollection matches = Regex.Matches(input, pattern2);
        Console.WriteLine("Found email addresses:");
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}       