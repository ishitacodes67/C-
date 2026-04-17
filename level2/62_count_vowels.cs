// Program to count vowels in a string
using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();
        int vowelCount = 0;

        foreach (char c in input)
        {
            if (IsVowel(c))
            {
                vowelCount++;
            }
        }

        Console.WriteLine("Number of vowels in the string: " + vowelCount);
    }

    static bool IsVowel(char c)
    {
        char lowerChar = char.ToLower(c);
        return lowerChar == 'a' || lowerChar == 'e' || lowerChar == 'i' || lowerChar == 'o' || lowerChar == 'u';
    }
}