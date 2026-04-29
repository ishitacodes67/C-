// Program to demonstrate LINQ (Join) 
using System;
using System.Collections.Generic; // Importing the Collections.Generic namespace for List
using System.Linq; // Importing the Linq namespace for LINQ operations
class Program   
{
    static void Main()
    {
        // Demonstrating LINQ with Join
        List<string> students = new List<string> { "Alice", "Bob", "Charlie" };
        List<string> courses = new List<string> { "Math", "Science", "History" };
        
        // Using Join to combine students and courses based on their index
        var studentCourses = students.Join(courses, 
                                           student => students.IndexOf(student), 
                                           course => courses.IndexOf(course), 
                                           (student, course) => $"{student} is enrolled in {course}");
        
        Console.WriteLine("Student-Course pairs:");
        foreach (var pair in studentCourses)
        {
            Console.WriteLine(pair);
        }
    }
}

