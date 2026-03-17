/* 15 COUNT DIGITS */ 
using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int num = Convert.ToInt32(Console.ReadLine());

        int count = 0;
        while (num != 0)
        {
            num /= 10;
            count++;
        }

        Console.WriteLine("The number of digits is: " + count);
    }
}
