// Program to demonstrate polymorphism
using System;
class Parent
{
    public virtual void show()
    {
        Console.WriteLine("Parent's show method");
    }
}
class Child : Parent
{
    public override void show()
    {
        Console.WriteLine("Child's show method");
    }
}
class Program
{
    static void Main()
    {
        Parent p = new Parent();
        p.show(); // Output: Parent's show method

        Child c = new Child();
        c.show(); // Output: Child's show method

        Parent pc = new Child();
        pc.show(); // Output: Child's show method (due to polymorphism)
    }
}
