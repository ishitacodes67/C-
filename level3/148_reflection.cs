// Program to demonstrate reflection 
using System;
using System.Reflection;
class SampleClass
{
    public string Name { get; set; }
    public int Age { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}
class ReflectionDemo
{
    static void Main(string[] args)
    {
        // Create an instance of SampleClass
        SampleClass sample = new SampleClass { Name = "Bob", Age = 25 };

        // Get the type information of SampleClass
        Type typeInfo = typeof(SampleClass);

        // Display the name of the class
        Console.WriteLine("Class Name: " + typeInfo.Name);

        // Display properties of the class
        Console.WriteLine("\nProperties:");
        PropertyInfo[] properties = typeInfo.GetProperties();
        foreach (var prop in properties)
        {
            Console.WriteLine($"- {prop.Name} ({prop.PropertyType.Name})");
        }

        // Display methods of the class
        Console.WriteLine("\nMethods:");
        MethodInfo[] methods = typeInfo.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
        foreach (var method in methods)
        {
            Console.WriteLine($"- {method.Name}");
        }

        // Invoke the DisplayInfo method using reflection
        MethodInfo displayMethod = typeInfo.GetMethod("DisplayInfo");
        if (displayMethod != null)
        {
            Console.WriteLine("\nInvoking DisplayInfo method:");
            displayMethod.Invoke(sample, null);
        }
    }
}

