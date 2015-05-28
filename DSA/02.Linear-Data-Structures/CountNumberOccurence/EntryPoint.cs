//// Write a program that finds in given array of integers (all belonging to the range [0..1000]) how many times each of them occurs.
//// Example: array = {3, 4, 4, 2, 3, 3, 4, 3, 2}
//// 2  2 times
//// 3  4 times
//// 4  3 times
using System;
using System.Collections.Generic;

public class EntryPoint
{
    public static void Main()
    {
        int[] numbers = { 3, 4, 4, 2, 3, 3, 4, 3, 2 };

        CountOccurence(numbers);
    }

    public static void CountOccurence(int[] numbers)
    {
        Dictionary<int, int> numberOccurence = new Dictionary<int, int>();

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numberOccurence.ContainsKey(numbers[i]))
            {
                numberOccurence[numbers[i]]++;
            }
            else
            {
                numberOccurence.Add(numbers[i], 1);
            }
        }

        foreach (var pair in numberOccurence)
        {
            Console.WriteLine("{0} -> {1} times", pair.Key, pair.Value);
        }
    }
}
