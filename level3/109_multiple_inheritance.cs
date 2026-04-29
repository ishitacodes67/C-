// Program to demonstrate multiple inheritance using interface
using System;

// Interfaces
interface IShape
{
    void Draw();
}

interface IColor
{
    void SetColor(string color);
}

// Implementing class
class Circle : IShape, IColor
{
    private string color;

    public void Draw()
    {
        Console.WriteLine($"Drawing a {color} circle");
    }

    public void SetColor(string color)
    {
        this.color = color;
    }
}

class Program
{
    static void Main()
    {
        IShape shape = new Circle();
        IColor color = new Circle();

        shape.Draw(); // This will not work as expected since we can't call SetColor on an IShape reference
        color.SetColor("red");
        shape.Draw(); // This will not work as expected since we can't call SetColor on an IShape reference
    }
}
