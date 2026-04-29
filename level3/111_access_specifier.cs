// Program to demonstrate access specifiers
using System;
// Class with different access specifiers
class Person
{
    public string Name; // Public access
    private int Age; // Private access
    protected string Address; // Protected access

    public void SetAge(int age)
    {
        Age = age;
    }

    public int GetAge()
    {
        return Age;
    }
}