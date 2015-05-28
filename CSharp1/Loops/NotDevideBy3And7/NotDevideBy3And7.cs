// Write a program that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time.
using System;

class NotDevideBy3And7
{
    static void Main()
    {
        Console.Write("Enter a number: ");

        int num = int.Parse(Console.ReadLine());

        for (int i = 1; i <= num; i++)
        {
            if (i % (3 * 7) != 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}

