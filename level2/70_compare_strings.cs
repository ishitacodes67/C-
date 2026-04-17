// Program to compare strings 
using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the first string:");
        string str1 = Console.ReadLine();
        Console.WriteLine("Enter the second string:");
        string str2 = Console.ReadLine();

        int result = string.Compare(str1, str2);
        if (result < 0)
        {
            Console.WriteLine("The first string is lexicographically smaller.");
        }
        else if (result > 0)
        {
            Console.WriteLine("The first string is lexicographically larger.");
        }
        else
        {
            Console.WriteLine("The strings are equal.");
        }
    }
}
