// Program to demonstrate struct 
using System;
struct Point
{
    public int X;
    public int Y;

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
}

class Program
{
    static void Main()
    {
        // Create a struct variable
        Point p = new Point(10, 20);

        // Display the values of the struct members
        Console.WriteLine("Point coordinates: ({0}, {1})", p.X, p.Y);
    }
}
