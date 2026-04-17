// Program to check palindrome string
using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();
        string cleanedString = "";
        foreach (char c in input)
        {
            if (char.IsLetter(c))
            {
                cleanedString += char.ToLower(c);
            }
        }
        bool isPalindrome = true;
        int left = 0;
        int right = cleanedString.Length - 1;
        while (left < right)
        {
            if (cleanedString[left] != cleanedString[right])
            {
                isPalindrome = false;
                break;
            }
            left++;
            right--;
        }
        if (isPalindrome)
        {
            Console.WriteLine("The string is a palindrome.");
        }
        else
        {
            Console.WriteLine("The string is not a palindrome.");
        }
    }
}