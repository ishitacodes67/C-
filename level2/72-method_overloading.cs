// Program to demonstrate method overloading 
using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the first number:");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number:");
        int num2 = int.Parse(Console.ReadLine());
        int sum = AddNumbers(num1, num2);
        Console.WriteLine("The sum is: " + sum);

        Console.WriteLine("Enter the first decimal number:");
        double dec1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second decimal number:");
        double dec2 = double.Parse(Console.ReadLine());
        double decimalSum = AddNumbers(dec1, dec2);
        Console.WriteLine("The sum of decimal numbers is: " + decimalSum);
    }

    static int AddNumbers(int a, int b)
    {
        return a + b;
    }

    static double AddNumbers(double a, double b)
    {
        return a + b;
    }
}   