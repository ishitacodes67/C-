/* PROGRAM TO DEMONSTRATE CONSTANTS AND READONLY */ 
using System;
class Program
{
    // Constant variable (value cannot be changed)
    const double Pi = 3.14159;

    // Readonly variable (value can be assigned only once, either at declaration or in constructor)
    readonly double radius;

    public Program(double r)
    {
        radius = r; // Assigning value to readonly variable in constructor
    }

    static void Main()
    {
        Console.WriteLine("Value of Pi: " + Pi);

        Console.WriteLine("Enter the radius of the circle:");
        double radiusInput = Convert.ToDouble(Console.ReadLine());

        Program programInstance = new Program(radiusInput);
        double area = Pi * programInstance.radius * programInstance.radius;
        Console.WriteLine("Area of the circle: " + area);
    }
}