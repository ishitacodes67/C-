// Program to demonstrate Span and ReadOnlySpan
using System;
using System.Text;
class Program
{
    static void Main()
    {
        // Create a Span of bytes
        byte[] byteArray = Encoding.UTF8.GetBytes("Hello, World!");
        Span<byte> byteSpan = byteArray;

        // Modify the Span
        for (int i = 0; i < byteSpan.Length; i++)
        {
            byteSpan[i] = (byte)(byteSpan[i] + 1); // Increment each byte by 1
        }

        // Display the modified Span as a string
        Console.WriteLine("Modified Span: " + Encoding.UTF8.GetString(byteSpan));

        // Create a ReadOnlySpan of bytes
        ReadOnlySpan<byte> readOnlyByteSpan = byteArray;

        // Display the ReadOnlySpan as a string
        Console.WriteLine("ReadOnlySpan: " + Encoding.UTF8.GetString(readOnlyByteSpan));
    }
}