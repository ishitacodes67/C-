// Program to demonstrate destructor
using System;
class DestructorDemo
{
    // Class definition
    class Employee
    {
        public string Name;

        public Employee(string name)
        {
            Name = name;
            Console.WriteLine($"Employee {Name} created.");
        }

        ~Employee() // Destructor (Finalizer)
        {
            Console.WriteLine($"Employee {Name} destroyed.");
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Destructor Demo in C#\n");

        // Creating objects (instances of the Employee class)
        Employee emp1 = new Employee("Alice");
        Employee emp2 = new Employee("Bob");

        // Removing reference (eligible for garbage collection)
        emp1 = null;

        Console.WriteLine("\nForcing Garbage Collection...");
        GC.Collect();          // Force GC
        GC.WaitForPendingFinalizers(); // Wait for destructor

        Console.WriteLine("\nEnd of program.");
        Console.ReadLine();
    }
}