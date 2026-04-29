// Program to demonstrate serialization (JSON) 
using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string City { get; set; }
}
class SerializationDemo
{
    static void Main(string[] args)
    {
        // Create a Person object
        Person person = new Person
        {
            Name = "Alice",
            Age = 30,
            City = "New York"
        };

        // Serialize the Person object to JSON
        string jsonString = JsonSerializer.Serialize(person);
        Console.WriteLine("Serialized JSON:\n" + jsonString);

        // Write the JSON string to a file
        string filePath = "person.json";
        File.WriteAllText(filePath, jsonString);
        Console.WriteLine("\nJSON written to file: " + filePath);

        // Read the JSON string from the file
        string jsonFromFile = File.ReadAllText(filePath);
        Console.WriteLine("\nJSON read from file:\n" + jsonFromFile);

        // Deserialize the JSON string back to a Person object
        Person deserializedPerson = JsonSerializer.Deserialize<Person>(jsonFromFile);
        Console.WriteLine("\nDeserialized Person Object:");
        Console.WriteLine($"Name: {deserializedPerson.Name}");
        Console.WriteLine($"Age: {deserializedPerson.Age}");
        Console.WriteLine($"City: {deserializedPerson.City}");
    }
}

