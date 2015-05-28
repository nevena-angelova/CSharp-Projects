//// Write a program that reads N integers from the console and reverses them using a stack. Use the Stack<int> class.
using System;
using System.Collections.Generic;

public class EntryPoint
{
    public static void Main()
    {
        Console.WriteLine("Enter N:");

        int n = int.Parse(Console.ReadLine());
        Stack<int> numbers = new Stack<int>();
        int number;

        Console.WriteLine("Enter {0} integers:", n);

        for (int i = 0; i < n; i++)
        {
            number = int.Parse(Console.ReadLine());
            numbers.Push(number);
        }

        Console.WriteLine("The numbers reversed:");
        Console.WriteLine(string.Join("\n", numbers));
    }
}