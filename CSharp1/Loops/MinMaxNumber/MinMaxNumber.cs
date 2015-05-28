// Write a program that reads from the console a sequence of N integer numbers and returns the minimal and maximal of them.
using System;

class MinMaxNumber
{
    static void Main()
    {
        Console.Write("How many numbers will be in the sequence? ");

        int sequence = int.Parse(Console.ReadLine());

        int max = int.MinValue;
        int min = int.MaxValue;

        for (int i = 0; i < sequence; i++)
        {
            Console.Write("Enter an integer: ");

            int num = int.Parse(Console.ReadLine());

            if (num > max)
            {
                max = num;
            }
            if (num < min)
            {
                min = num;
            }
        }

        Console.WriteLine("The maximum number is: {0}", max);
        Console.WriteLine("The minimum number is: {0}", min);
    }
}

