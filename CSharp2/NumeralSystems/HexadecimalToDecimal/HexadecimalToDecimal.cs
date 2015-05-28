//Write a program to convert hexadecimal numbers to their decimal representation.
using System;
using System.Collections.Generic;

class HexadecimalToDecimal
{
    static void Main()
    {
        Console.WriteLine("Enter a hexadecimal number");

        string hexNum = Console.ReadLine();

        List<int> numbers = new List<int>();

        for (int i = 0; i < hexNum.Length; i++)
        {
            switch (hexNum[i])
            {
                case 'A': numbers.Add(10); break;
                case 'B': numbers.Add(11); break;
                case 'C': numbers.Add(12); break;
                case 'D': numbers.Add(13); break;
                case 'E': numbers.Add(14); break;
                case 'F': numbers.Add(15); break;
                default: numbers.Add((int)char.GetNumericValue(hexNum[i])); break;
            }
        }

        int sum = 0;

        for (int j = 0; j < numbers.Count; j++)
        {
            sum += numbers[numbers.Count-j-1] * (int)Math.Pow(16,j);
        }

        Console.WriteLine(sum);

    }
}

