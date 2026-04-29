// Program to demonstrate abstract class vs interface
using System;
// Abstract class
abstract class Shape
{
    public abstract void Draw();
}
// Interface
interface IColor
{
    void SetColor(string color);
}
// Derived class implementing both abstract class and interface
class Circle : Shape, IColor
{
    private string color;

    public override void Draw()
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
        Circle myCircle = new Circle();
        myCircle.SetColor("red");
        myCircle.Draw(); // Output: Drawing a red circle
    }
}
