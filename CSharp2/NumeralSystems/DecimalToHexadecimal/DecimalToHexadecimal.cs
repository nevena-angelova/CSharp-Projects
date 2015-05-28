//Write a program to convert decimal numbers to their hexadecimal representation.
using System;
using System.Collections.Generic;

class DecimalToHexadecimal
{
    static void Main()
    {
        Console.WriteLine("Enter a decimal number");
        int num = int.Parse(Console.ReadLine());
        int reminder = 0;

        List<string> numbers = new List<string>();

        while (num > 0)
        {
            reminder = num % 16;
            num /= 16;

            if (reminder < 10)
            {
                numbers.Add(reminder.ToString());
            }
            else
            {
                switch (reminder)
                {
                    case 10: numbers.Add("A"); break;
                    case 11: numbers.Add("B"); break;
                    case 12: numbers.Add("C"); break;
                    case 13: numbers.Add("D"); break;
                    case 14: numbers.Add("E"); break;
                    case 15: numbers.Add("F"); break;
                    default: break;
                }
            }
        }

        for (int i = numbers.Count - 1; i >= 0; i--)
        {
            Console.Write(numbers[i]);
        }

        Console.WriteLine();
    }
}

