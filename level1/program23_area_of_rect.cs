/* PROGRAM TO CALCULATE AREA OF A RECTANCLE */
using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter length of the rectangle:");
        double length = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter width of the rectangle:");
        double width = Convert.ToDouble(Console.ReadLine());
        double area = length * width;
        Console.WriteLine("Area of the rectangle: " + area);
    }
}