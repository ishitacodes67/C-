// Program to demonstrate named arguments 
using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int n = int.Parse(Console.ReadLine());
        long factorial = CalculateFactorial(n: n);
        Console.WriteLine("The factorial of {0} is: {1}", n, factorial);

        // Using named argument
        long factorialWithNamedArg = CalculateFactorial(n: 5);
        Console.WriteLine("The factorial of 5 is: {0}", factorialWithNamedArg);
    }

    static long CalculateFactorial(int n)
    {
        if (n == 0)
            return 1;
        else
            return n * CalculateFactorial(n - 1);
    }
}
