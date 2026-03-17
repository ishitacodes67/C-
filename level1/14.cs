/* FIBONACCI SERIES */ 
using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the number of terms for Fibonacci series:");
        int terms = Convert.ToInt32(Console.ReadLine());

        int a = 0, b = 1, c;
        Console.WriteLine("Fibonacci Series:");
        for (int i = 1; i <= terms; i++)
        {
            Console.Write(a + " ");
            c = a + b;
            a = b;
            b = c;
        }
    }
}