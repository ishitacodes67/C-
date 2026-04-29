// Program to demonstrate lambda expressions
using System;
class Program   
{
    static void Main()
    {
        // Demonstrating lambda expressions
        Func<int, int, int> add = (a, b) => a + b; // Lambda expression for addition
        Func<int, int, int> multiply = (a, b) => a * b; // Lambda expression for multiplication
        
        int sum = add(5, 3);
        int product = multiply(5, 3);
        
        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Product: {product}");
    }
}
