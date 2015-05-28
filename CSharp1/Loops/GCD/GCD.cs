// Write a program that calculates the greatest common divisor (GCD) of given two numbers. Use the Euclidean algorithm (find it in Internet).
using System;

class GCD
{
    static void Main()
    {
        Console.WriteLine("Enter two numbers (the first one bigger tham the second): ");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        int reminder = 1;

        while (reminder != 0)
        {
            reminder = a % b;
            a = b;
            b = reminder;
        }

        Console.WriteLine("The greatest common divisor is: {0}", a);

    }
}

