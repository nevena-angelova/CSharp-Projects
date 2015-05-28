//// Write a program that removes from given sequence all numbers that occur odd number of times. Example:
//// {4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2}  {5, 3, 3, 5}
using System;
using System.Collections.Generic;

public class EntryPoint
{
    public static void Main()
    {
        List<int> numbers = new List<int>()
            {
                4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2
            };

        Console.WriteLine("In {0}", string.Join(", ", numbers));
        Console.WriteLine("The removed numbers should be: {0}", string.Join(", ", RemoveItems(numbers)));
    }

    public static List<int> RemoveItems(List<int> numbers)
    {
        Dictionary<int, int> numberOccurence = new Dictionary<int, int>();

        for (int i = 0; i < numbers.Count; i++)
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

        List<int> result = new List<int>();

        foreach (var pair in numberOccurence)
        {
            if (pair.Value % 2 == 0)
            {
                for (int i = 0; i < pair.Value; i++)
                {
                    result.Add(pair.Key);
                }
            }
        }

        return result;
    }
}