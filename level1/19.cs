/* check vowel */
using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a character:");
        char ch = Convert.ToChar(Console.ReadLine().ToLower());

        if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
        {
            Console.WriteLine(ch + " is a vowel.");
        }
        else
        {
            Console.WriteLine(ch + " is not a vowel.");
        }
    }
}