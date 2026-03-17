/* SUM OF FIRST 10 NUMBERS */ 
using System;
class Program
{
    static void Main()
    {
        int sum = 0;
        for (int i = 1; i <= 10; i++)
        {
            sum += i;
        }
        Console.WriteLine("The sum of the first 10 numbers is: " + sum);
    }
}