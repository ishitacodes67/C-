/* PROGRAM TO CALCULATE ASCII VALUE OF A CHARACTER */
using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a character:");
        char character = Convert.ToChar(Console.ReadLine());
        int asciiValue = (int)character;
        Console.WriteLine("ASCII value of '" + character + "' is: " + asciiValue);
    }
}   