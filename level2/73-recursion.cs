// Program to demonstrate recursion 
using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int n = int.Parse(Console.ReadLine());
        long factorial = CalculateFactorial(n);
        Console.WriteLine("The factorial of {0} is: {1}", n, factorial);
    }

    static long CalculateFactorial(int n)
    {
        if (n == 0)
            return 1;
        else
            return n * CalculateFactorial(n - 1);
    }
}

