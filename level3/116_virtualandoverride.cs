// Program to demonstrate virtual and override 
using System;
// Base class
class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes a sound");
    }
}
// Derived class
class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Dog barks");
    }
}
class Program
{
    static void Main()
    {
        Animal myAnimal = new Animal();
        myAnimal.MakeSound(); // Output: Animal makes a sound

        Dog myDog = new Dog();
        myDog.MakeSound(); // Output: Dog barks

        // Polymorphism
        Animal animalDog = new Dog();
        animalDog.MakeSound(); // Output: Dog barks
    }
}
