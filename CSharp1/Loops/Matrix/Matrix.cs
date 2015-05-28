// Write a program that prints all possible cards from a standard deck of 52 cards (without jokers).
// The cards should be printed with their English names. Use nested for loops and switch-case.
using System;

class Matrix
{
    static void Main()
    {
        Console.Write("Enter a number N (N<20): ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine();

        for (int i = 1; i <= n; i++)
        {
            for (int j = i; j <= i + n - 1; j++)
            {
                Console.Write("{0,3}", j);
            }

            Console.WriteLine();
            Console.WriteLine();
        }
    }
}

