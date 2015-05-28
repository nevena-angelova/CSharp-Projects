//// Write a program that removes from given sequence all negative numbers.
using System;
using System.Collections.Generic;

public class EntryPoint
{
    public static void Main()
    {
        List<int> numbers = new List<int>()
            {
                -4, 2, 2, 5, -2, 3, -31, 3, 1, 5, -5, 5, 5
            };

        Console.WriteLine("In {0},", string.Join(", ", numbers));
        Console.WriteLine("The positive numbers are: {0}", string.Join(", ", RemoveNegativeNumbers(numbers)));
    }

    public static List<int> RemoveNegativeNumbers(List<int> numbers)
    {
        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] < 0)
            {
                numbers.Remove(numbers[i]);
            }
        }

        return numbers;
    }
}