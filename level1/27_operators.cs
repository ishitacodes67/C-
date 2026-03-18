/* PROGRAM TO DEMONSTRATE OPERATORS */
using System;
class Program
{
    static void Main()
    {
        int a = 10;
        int b = 5;

        // Arithmetic Operators
        Console.WriteLine("Arithmetic Operators:");
        Console.WriteLine("a + b = " + (a + b)); // Addition
        Console.WriteLine("a - b = " + (a - b)); // Subtraction
        Console.WriteLine("a * b = " + (a * b)); // Multiplication
        Console.WriteLine("a / b = " + (a / b)); // Division
        Console.WriteLine("a % b = " + (a % b)); // Modulus

        // Comparison Operators
        Console.WriteLine("\nComparison Operators:");
        Console.WriteLine("a == b: " + (a == b)); // Equal to
        Console.WriteLine("a != b: " + (a != b)); // Not equal to
        Console.WriteLine("a > b: " + (a > b));   // Greater than
        Console.WriteLine("a < b: " + (a < b));   // Less than
        Console.WriteLine("a >= b: " + (a >= b)); // Greater than or equal to
        Console.WriteLine("a <= b: " + (a <= b)); // Less than or equal to

        // Logical Operators
        bool x = true;
        bool y = false;
        Console.WriteLine("\nLogical Operators:");
        Console.WriteLine("x && y: " + (x && y)); // Logical AND
        Console.WriteLine("x || y: " + (x || y)); // Logical OR
        Console.WriteLine("!x: " + (!x));         // Logical NOT
    }
}