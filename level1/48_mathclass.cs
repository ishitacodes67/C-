// Program to demonstrate Math class
using System;
class Program
{
    static void Main()
    {
        double number = 16.0;

        // Using Math.Sqrt to calculate the square root
        double sqrtResult = Math.Sqrt(number);
        Console.WriteLine($"Square root of {number} is {sqrtResult}");

        // Using Math.Pow to calculate the power
        double powerResult = Math.Pow(number, 2);
        Console.WriteLine($"{number} raised to the power of 2 is {powerResult}");

        // Using Math.Abs to calculate the absolute value
        double negativeNumber = -5.5;
        double absResult = Math.Abs(negativeNumber);
        Console.WriteLine($"Absolute value of {negativeNumber} is {absResult}");
    }
}