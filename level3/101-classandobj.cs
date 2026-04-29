// Program to demonstrate class and object
using System;
class ClassAndObjectDemo
{
    // Class definition
    class Car
    {
        public string Make;
        public string Model;
        public int Year;

        // Constructor
        public Car(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }

        // Method to display car details
        public void DisplayInfo()
        {
            Console.WriteLine($"Car: {Year} {Make} {Model}");
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Class and Object Demo in C#\n");

        // Creating objects (instances of the Car class)
        Car car1 = new Car("Toyota", "Camry", 2020);
        Car car2 = new Car("Honda", "Civic", 2019);

        // Displaying information about the cars
        car1.DisplayInfo();
        car2.DisplayInfo();

        Console.WriteLine("\nEnd of program.");
        Console.ReadLine();
    }
}