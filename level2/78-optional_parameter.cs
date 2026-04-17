// Program to demonstrate optional parameters 
using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int n = int.Parse(Console.ReadLine());
        long factorial = CalculateFactorial(n);
        Console.WriteLine("The factorial of {0} is: {1}", n, factorial);

        // Using optional parameter
        long factorialWithDefault = CalculateFactorial();
        Console.WriteLine("The factorial of default value (5) is: {0}", factorialWithDefault);
    }

    static long CalculateFactorial(int n = 5)
    {
        if (n == 0)
            return 1;
        else
            return n * CalculateFactorial(n - 1);
    }
}
