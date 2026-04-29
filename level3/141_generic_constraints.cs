// Program to demonstrate generic constraints 
using System;
// Define a generic class with a constraint that T must be a reference type
class GenericContainer<T> where T : class
{
    private T data;

    public void SetData(T value)
    {
        data = value;
    }

    public T GetData()
    {
        return data;
    }
}
class Program
{
    static void Main()
    {
        // Create a generic container for strings (reference type)
        GenericContainer<string> stringContainer = new GenericContainer<string>();
        stringContainer.SetData("Hello, Constraints!");
        Console.WriteLine($"String value: {stringContainer.GetData()}");

        // The following line would cause a compile-time error because int is a value type
        // GenericContainer<int> intContainer = new GenericContainer<int>();
    }
}

