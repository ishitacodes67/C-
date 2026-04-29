// Program to demonstrate inheritance
using System;
class Inheritance
{
    // Base class (Parent)
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Animal is eating.");
        }
    }

    // Derived class (Child) inheriting from Animal
    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Dog is barking.");
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Inheritance Demo in C#\n");

        // Creating an object of the derived class
        Dog myDog = new Dog();

        // Accessing method from the base class
        myDog.Eat(); // Inherited method

        // Accessing method from the derived class
        myDog.Bark(); // Dog's own method

        Console.WriteLine("\nEnd of program.");
        Console.ReadLine();
    }
}