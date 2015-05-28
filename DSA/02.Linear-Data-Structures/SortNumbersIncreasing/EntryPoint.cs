//// Write a program that reads a sequence of integers (List<int>) ending with an empty line and sorts them in an increasing order.
using System;
using System.Collections.Generic;

public class EntryPoint
{
    public static void Main()
    {
        string inputStr;
        int number;
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter numbers:");

        while (true)
        {
            inputStr = Console.ReadLine();

            if (inputStr == string.Empty)
            {
                break;
            }
            else
            {
                bool isNumber = int.TryParse(inputStr, out number);

                if (!isNumber)
                {
                    throw new ArgumentException("Invalid input data!");
                }
                else
                {
                    numbers.Add(number);
                }
            }
        }

        numbers.Sort();

        Console.WriteLine(string.Join("\n", numbers));
    }
}
