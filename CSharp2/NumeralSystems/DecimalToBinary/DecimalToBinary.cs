//Write a program to convert decimal numbers to their binary representation.
using System;
using System.Collections.Generic;

class DecimalToBinary
{
    static void Main()
    {
        Console.WriteLine("Enter a decimal number");

        int num = int.Parse(Console.ReadLine());

        List<int> numbers = new List<int>();

        while (num > 0)
        {
            int reminder = num % 2;
            num /= 2;
            numbers.Add(reminder);
        }

        for (int i = numbers.Count - 1; i >= 0; i--)
        {
            Console.Write(numbers[i]);
        }
        Console.WriteLine();

    }
}

