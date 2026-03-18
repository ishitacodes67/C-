/* PROGRAM TO CALCULATE GRADE OF A STUDENT */
using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the marks obtained:");
        int marks = Convert.ToInt32(Console.ReadLine());

        string grade;

        if (marks >= 90)
        {
            grade = "A";
        }
        else if (marks >= 80)
        {
            grade = "B";
        }
        else if (marks >= 70)
        {
            grade = "C";
        }
        else if (marks >= 60)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
        }

        Console.WriteLine("Grade: " + grade);
    }
}