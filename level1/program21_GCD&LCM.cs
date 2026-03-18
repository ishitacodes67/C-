/* PROGRAM TO FIND GCD AND LCM */ 
using System;
class Program
{
    static void Main()
    {
        int a, b, gcd, lcm;
        Console.WriteLine("Enter two numbers:");
        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());
        
        // Calculate GCD
        gcd = GCD(a, b);
        
        // Calculate LCM
        lcm = (a * b) / gcd;
        
        Console.WriteLine("GCD: " + gcd);
        Console.WriteLine("LCM: " + lcm);
    }
    
    static int GCD(int x, int y)
    {
        while (y != 0)
        {
            int temp = y;
            y = x % y;
            x = temp;
        }
        return x;
    }
}