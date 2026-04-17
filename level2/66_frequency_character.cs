// Program to find frequency of characters
using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();
        int[] frequency = new int[256]; // Assuming ASCII character set

        // Calculate frequency of each character
        foreach (char c in input)
        {
            frequency[c]++;
        }

        Console.WriteLine("Character Frequency:");
        for (int i = 0; i < frequency.Length; i++)
        {
            if (frequency[i] > 0)
            {
                Console.WriteLine((char)i + ": " + frequency[i]);
            }
        }
    }
}