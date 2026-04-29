// Program to demonstrate constructor 
using System;
class ConstructorDemo
{
    // Class definition
    class Student
    {
        public string Name;
        public int Age;

        // Constructor
        public Student(string name, int age)
        {
            Name = name;
            Age = age;
            Console.WriteLine($"Student {Name} created with age {Age}.");
        }

        // Method to display student details
        public void DisplayInfo()
        {
            Console.WriteLine($"Student: {Name}, Age: {Age}");
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Constructor Demo in C#\n");

        // Creating objects (instances of the Student class)
        Student student1 = new Student("Alice", 20);
        Student student2 = new Student("Bob", 22);

        // Displaying information about the students
        student1.DisplayInfo();
        student2.DisplayInfo();

        Console.WriteLine("\nEnd of program.");
        Console.ReadLine();
    }
}
