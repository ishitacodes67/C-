// Program to demonstrate attributes
using System;
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, Inherited = false)]
class MyCustomAttribute : Attribute
{
    public string Description { get; }
    public MyCustomAttribute(string description)
    {
        Description = description;
    }
}
[MyCustomAttribute("This is a sample class with a custom attribute.")]
class SampleClass
{
    [MyCustomAttribute("This is a sample method with a custom attribute.")]
    public void SampleMethod()
    {
        Console.WriteLine("Executing SampleMethod...");
    }
}
class AttributesDemo
{
    static void Main(string[] args)
    {
        // Get the type information of SampleClass
        Type typeInfo = typeof(SampleClass);

        // Check if the class has the MyCustomAttribute
        if (Attribute.IsDefined(typeInfo, typeof(MyCustomAttribute)))
        {
            MyCustomAttribute classAttribute = (MyCustomAttribute)Attribute.GetCustomAttribute(typeInfo, typeof(MyCustomAttribute));
            Console.WriteLine("Class Attribute Description: " + classAttribute.Description);
        }

        // Get the method information for SampleMethod
        var methodInfo = typeInfo.GetMethod("SampleMethod");
        if (methodInfo != null && Attribute.IsDefined(methodInfo, typeof(MyCustomAttribute)))
        {
            MyCustomAttribute methodAttribute = (MyCustomAttribute)Attribute.GetCustomAttribute(methodInfo, typeof(MyCustomAttribute));
            Console.WriteLine("Method Attribute Description: " + methodAttribute.Description);
        }
    }
}
