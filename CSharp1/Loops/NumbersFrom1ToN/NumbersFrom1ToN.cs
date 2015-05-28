// Write a program that prints all the numbers from 1 to N.
using System;

class NumbersFrom1ToN
{
    static void Main()
    {
        Console.Write("Enter a number: ");

        int num = int.Parse(Console.ReadLine());

        for (int i = 1; i <= num; i++)
        {
            Console.WriteLine(i);
        }

    }
}

