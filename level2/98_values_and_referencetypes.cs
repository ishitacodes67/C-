// Program to demonstrate value vs reference types
using System;
class Program
{
    static void Main()
    {
        // Value type example
        int a = 5;
        int b = a; // b gets a copy of the value of a
        b = 10; // Modifying b does not affect a
        Console.WriteLine($"Value Types: a = {a}, b = {b}"); // Output: a = 5, b = 10

        // Reference type example
        int[] arrayA = { 1, 2, 3 };
        int[] arrayB = arrayA; // arrayB references the same array as arrayA
        arrayB[0] = 10; // Modifying arrayB affects arrayA since they reference the same object
        Console.WriteLine($"Reference Types: arrayA[0] = {arrayA[0]}, arrayB[0] = {arrayB[0]}"); // Output: arrayA[0] = 10, arrayB[0] = 10
    }
}