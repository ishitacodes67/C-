// Console-based Student Management System
using System;
class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}
class StudentManagementSystem
{
    private List<Student> students = new List<Student>();

    public void AddStudent()
    {
        Console.WriteLine("Enter Student ID:");
        int id = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Student Name:");
        string name = Console.ReadLine();
        Console.WriteLine("Enter Student Age:");
        int age = int.Parse(Console.ReadLine());

        students.Add(new Student { Id = id, Name = name, Age = age });
        Console.WriteLine("Student added successfully!");
    }

    public void ViewStudents()
    {
        Console.WriteLine("Student List:");
        foreach (var student in students)
        {
            Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}");
        }
    }

    public void UpdateStudent()
    {
        Console.WriteLine("Enter Student ID to update:");
        int id = int.Parse(Console.ReadLine());
        var student = students.FirstOrDefault(s => s.Id == id);
        if (student != null)
        {
            Console.WriteLine("Enter new name:");
            student.Name = Console.ReadLine();
            Console.WriteLine("Enter new age:");
            student.Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Student updated successfully!");
        }
        else
        {
            Console.WriteLine("Student not found.");
        }
    }

    public void DeleteStudent()
    {
        Console.WriteLine("Enter Student ID to delete:");
        int id = int.Parse(Console.ReadLine());
        var student = students.FirstOrDefault(s => s.Id == id);
        if (student != null)
        {
            students.Remove(student);
            Console.WriteLine("Student deleted successfully!");
        }
        else
        {
            Console.WriteLine("Student not found.");
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        StudentManagementSystem sms = new StudentManagementSystem();
        while (true)
        {
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. View Students");
            Console.WriteLine("3. Update Student");
            Console.WriteLine("4. Delete Student");
            Console.WriteLine("5. Exit");
            Console.WriteLine("Enter your choice:");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    sms.AddStudent();
                    break;
                case 2:
                    sms.ViewStudents();
                    break;
                case 3:
                    sms.UpdateStudent();
                    break;
                case 4:
                    sms.DeleteStudent();
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
