// Write a program that finds the greatest of given 5 variables.
using System;

class MaxNumber
{
    static void Main()
    {
        int[] numbers = new int[5];
        int max = int.MinValue;

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine());
            numbers[i] = number;

            if (numbers[i] >= max)
            {
                max = numbers[i];
            }
        }

        Console.WriteLine("The biggest number is {0}", max);
    }
}

