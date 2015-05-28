// Write a method that asks the user for his name and prints “Hello, <name>” (for example, “Hello, Peter!”).
// Write a program to test this method.


using System;

public class PrintHello
{
    static void Main()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        PrintName(name);
    }

    public static string PrintName(string name)
    {
        Console.WriteLine("Hello, {0}!", name);
        return name;
    }
}

