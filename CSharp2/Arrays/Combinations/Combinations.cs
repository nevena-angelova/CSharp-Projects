//Write a program that reads two numbers N and K and generates all the combinations of K distinct elements from the set [1..N]. Example:
//N = 5, K = 2  {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}

using System;


class Combinations
{
    static int n = int.Parse(Console.ReadLine());
    static int k = int.Parse(Console.ReadLine());

    static void Main()
    {
        int[] combinations = new int[k];

        GenerateCombinations(0, 1, combinations);
    }
    
    static void GenerateCombinations(int index, int currentIndex, int[] combinations)
    {
        if (index == k)
        {
            foreach (int item in combinations)
            {
                Console.Write(item);
            }

            Console.WriteLine();
        }
        else
        {
            for (int i = currentIndex; i <= n; i++)
            {
                combinations[index] = i;
                GenerateCombinations(index + 1, i + 1, combinations);
            }
        }

    }

}

