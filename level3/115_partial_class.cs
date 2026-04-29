// Program to demonstrate partial class
using System;
// Partial class definition in one file
partial class PartialClass
{
    public void MethodA()
    {
        Console.WriteLine("Method A from PartialClass.");
    }
}
// Partial class definition in another file
partial class PartialClass
{
    public void MethodB()
    {
        Console.WriteLine("Method B from PartialClass.");
    }
}
class Program
{
    static void Main()
    {
        PartialClass partialClass = new PartialClass();
        partialClass.MethodA();
        partialClass.MethodB();
    }
}
