// Program to check anagram strings 
using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the first string:");
        string str1 = Console.ReadLine();
        Console.WriteLine("Enter the second string:");
        string str2 = Console.ReadLine();
        bool isAnagram = CheckAnagram(str1, str2);
        if (isAnagram)
            Console.WriteLine("The strings are anagrams.");
        else
            Console.WriteLine("The strings are not anagrams.");
    }

    static bool CheckAnagram(string s1, string s2)
    {
        // Remove spaces and convert to lowercase
        s1 = s1.Replace(" ", "").ToLower();
        s2 = s2.Replace(" ", "").ToLower();

        // If lengths are different, they can't be anagrams
        if (s1.Length != s2.Length)
            return false;

        // Create arrays to count frequency of each character
        int[] count1 = new int[256];
        int[] count2 = new int[256];

        // Count frequency of characters in both strings
        for (int i = 0; i < s1.Length; i++)
        {
            count1[s1[i]]++;
            count2[s2[i]]++;
        }

        // Compare the frequency arrays
        for (int i = 0; i < 256; i++)
        {
            if (count1[i] != count2[i])
                return false;
        }

        return true;
    }
}

