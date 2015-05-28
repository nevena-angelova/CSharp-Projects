// Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤  16).

using System;
using System.Collections.Generic;

class AnyToAny
{
    static void Main()
    {
        Console.WriteLine("Enter from which one numeral system to convert (2-16)");
        int s = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter to which one numeral system to convert (2-16)");
        int d = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter a number");
        string n = Console.ReadLine();
        int num = 0;
        int decNum = 0;

        //convert to decimal

        if (s <= 10)
        {
            num = int.Parse(n);

            int power = 0;

            while (num > 0)
            {
                decNum += num % 10 * (int)Math.Pow(s, power);
                num /= 10;
                power++;
            }
        }
        else
        {
            List<int> hexNumbers = new List<int>();

            for (int i = 0; i < n.Length; i++)
            {
                switch (n[i])
                {
                    case 'A': hexNumbers.Add(10); break;
                    case 'B': hexNumbers.Add(11); break;
                    case 'C': hexNumbers.Add(12); break;
                    case 'D': hexNumbers.Add(13); break;
                    case 'E': hexNumbers.Add(14); break;
                    case 'F': hexNumbers.Add(15); break;
                    default: hexNumbers.Add((int)char.GetNumericValue(n[i])); break;
                }
            }

            for (int j = 0; j < hexNumbers.Count; j++)
            {
                decNum += hexNumbers[hexNumbers.Count - j - 1] * (int)Math.Pow(16, j);
            }
        }

        // convert to any

        List<string> numbers = new List<string>();

        if (d <= 10)
        {

            while (decNum > 0)
            {
                int reminder = decNum % d;
                decNum /= d;
                numbers.Add(reminder.ToString());
            }
        }
        else
        {
            int reminder = 0;
            while (decNum > 0)
            {
                reminder = decNum % d;
                decNum /= d;

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
        }

        // print the result

        for (int i = numbers.Count - 1; i >= 0; i--)
        {
            Console.Write(numbers[i]);
        }

        Console.WriteLine();
    }
}

