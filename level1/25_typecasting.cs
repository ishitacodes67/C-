/* PROGRAM TO DEMONSTRATE TYPE CASTING */ 
using System;
class Program
{
    static void Main()
    {
        // Implicit type casting (widening conversion)
        int num1 = 10;
        double num2 = num1; // int to double
        Console.WriteLine("Implicit type casting (int to double): " + num2);

        // Explicit type casting (narrowing conversion)
        double num3 = 9.99;
        int num4 = (int)num3; // double to int
        Console.WriteLine("Explicit type casting (double to int): " + num4);
    }
}