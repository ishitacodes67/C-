/* REVERSE A NUMBER */
using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int num = Convert.ToInt32(Console.ReadLine());

        int reversed = 0;
        while (num > 0)
        {
            int digit = num % 10;
            reversed = (reversed * 10) + digit;
            num /= 10;
        }

        Console.WriteLine("The reversed number is: " + reversed);
    }
}