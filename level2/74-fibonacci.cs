// Program to generate Fibonacci using recursion
using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the number of Fibonacci terms to generate:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Fibonacci series up to {0} terms:", n);
        for (int i = 0; i < n; i++)
        {
            Console.Write(Fibonacci(i) + " ");
        }
    }

    static long Fibonacci(int n)
    {
        if (n <= 1)
            return n;
        else
            return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
}