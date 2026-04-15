// Program to demonstrate tuples 
using System;
class Program
{
    static void Main()
    {
        // Create a tuple to hold multiple values
        var person = ("Alice", 30, "Engineer");

        // Access tuple elements
        Console.WriteLine("Name: " + person.Item1);
        Console.WriteLine("Age: " + person.Item2);
        Console.WriteLine("Profession: " + person.Item3);

        // Deconstruct the tuple into separate variables
        var (name, age, profession) = person;
        Console.WriteLine("\nDeconstructed Tuple:");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Profession: " + profession);
    }
}
