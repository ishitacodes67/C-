/* AVERAGE OF NUMBERS */ 
using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the number of elements:");
        int n = Convert.ToInt32(Console.ReadLine());

        double sum = 0;
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("Enter number " + i + ":");
            sum += Convert.ToDouble(Console.ReadLine());
        }

        double average = sum / n;
        Console.WriteLine("The average is: " + average);
    }
}