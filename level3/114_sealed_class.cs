// Program to demonstrate sealed class
using System;
// Sealed class
sealed class FinalClass
{
    public void Display()
    {
        Console.WriteLine("This is a sealed class.");
    }
}
// Attempting to inherit from a sealed class will result in a compile-time error
// class DerivedClass : FinalClass
// {
// }
class Program
{
    static void Main()
    {
        FinalClass finalClass = new FinalClass();
        finalClass.Display();
    }
}   
