// Program to demonstrate delegates
using System;
// Define a delegate that takes two integers and returns an integer
delegate int Operation(int a, int b);
class Program
{
    static void Main()
    {
        // Demonstrating delegates
        Operation add = (a, b) => a + b;
        Operation multiply = (a, b) => a * b;

        int sum = add(5, 3);
        int product = multiply(5, 3);

        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Product: {product}");
    }
}
