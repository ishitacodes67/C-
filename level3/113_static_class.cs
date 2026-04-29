// Program to demonstrate static class 
using System;
// Static class
static class MathUtilities
{
    public static double Pi = 3.14159;

    public static double CalculateCircleArea(double radius)
    {
        return Pi * radius * radius;
    }
}
class Program
{
    static void Main()
    {
        double radius = 5.0;
        double area = MathUtilities.CalculateCircleArea(radius);
        Console.WriteLine($"Area of circle with radius {radius} is: {area}");
    }
}

