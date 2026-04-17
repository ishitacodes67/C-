// Program to demonstrate memory management basics 
using System;

class MemoryDemo
{
    // Class to demonstrate heap allocation
    class Person
    {
        public string Name;

        public Person(string name)
        {
            Name = name;
            Console.WriteLine($"Object {Name} created.");
        }

        ~Person() // Destructor (Finalizer)
        {
            Console.WriteLine($"Object {Name} destroyed.");
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Memory Management Demo in C#\n");

        // Stack allocation (value types)
        int a = 10;
        int b = 20;
        Console.WriteLine($"Stack variables: a = {a}, b = {b}");

        // Heap allocation (reference types)
        Person p1 = new Person("Alice");
        Person p2 = new Person("Bob");

        // Removing reference (eligible for garbage collection)
        p1 = null;

        Console.WriteLine("\nForcing Garbage Collection...");
        GC.Collect();          // Force GC
        GC.WaitForPendingFinalizers(); // Wait for destructor

        Console.WriteLine("\nEnd of program.");
        Console.ReadLine();
    }
}

