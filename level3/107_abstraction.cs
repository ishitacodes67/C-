// Program to demonstrate abstraction
using System;
// Abstract class
abstract class Shape
{
    public abstract void Draw();
}   
// Derived class
class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a circle");
    }
}
class Program
{
    static void Main()
    {
        Shape shape = new Circle();
        shape.Draw();
    }
}
