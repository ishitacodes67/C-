// Program to demonstrate var and dynamic 
using System;
class Program
{
    static void Main()
    {
        // Using var to declare a variable
        var number = 10; // The type of 'number' is inferred as int
        Console.WriteLine("Value of number: " + number);
        Console.WriteLine("Type of number: " + number.GetType());

        // Using dynamic to declare a variable
        dynamic dynamicNumber = 20; // The type of 'dynamicNumber' is determined at runtime
        Console.WriteLine("Value of dynamicNumber: " + dynamicNumber);
        Console.WriteLine("Type of dynamicNumber: " + dynamicNumber.GetType());

        // Changing the value and type of dynamic variable
        dynamicNumber = "Now I'm a string!";
        Console.WriteLine("Value of dynamicNumber: " + dynamicNumber);
        Console.WriteLine("Type of dynamicNumber: " + dynamicNumber.GetType());
    }
}
