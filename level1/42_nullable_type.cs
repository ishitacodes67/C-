// Program to demonstrate nullable types
using System;
class Program   
{
    static void Main()
    {
        // Declare a nullable integer
        int? nullableInt = null;

        // Check if the nullable integer has a value
        if (nullableInt.HasValue)
        {
            Console.WriteLine($"The value is: {nullableInt.Value}");
        }
        else
        {
            Console.WriteLine("The nullable integer does not have a value.");
        }

        // Assign a value to the nullable integer
        nullableInt = 42;

        // Now it has a value
        if (nullableInt.HasValue)
        {
            Console.WriteLine($"The value is: {nullableInt.Value}");
        }
    }
}