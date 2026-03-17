/*  PALINDROME NUMBER */ 
using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int num = Convert.ToInt32(Console.ReadLine());

        int originalNum = num;
        int reversed = 0;

        while (num > 0)
        {
            int digit = num % 10;
            reversed = (reversed * 10) + digit;
            num /= 10;
        }

        if (originalNum == reversed)
        {
            Console.WriteLine(originalNum + " is a palindrome number.");
        }
        else
        {
            Console.WriteLine(originalNum + " is not a palindrome number.");
        }
    }
}