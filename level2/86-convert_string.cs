//  Program to convert string to uppercase/lowercase 
using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();
        Console.WriteLine("Choose an option:");
        Console.WriteLine("1. Convert to Uppercase");
        Console.WriteLine("2. Convert to Lowercase");
        int choice = int.Parse(Console.ReadLine());
        string result = ConvertString(input, choice);
        Console.WriteLine("The converted string is: {0}", result);
    }

    static string ConvertString(string str, int choice)
    {
        if (choice == 1)
            return str.ToUpper();
        else if (choice == 2)
            return str.ToLower();
        else
            return "Invalid choice";
    }
}  
