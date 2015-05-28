//Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N]. Example:
//N = 3, K = 2  {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}

using System;

class Variations
{

    static int n = int.Parse(Console.ReadLine());
    static int k = int.Parse(Console.ReadLine());

    static void Main()
    {
        int[] variations = new int[k];

        GenerateVariations(0, variations);
    }


    static void GenerateVariations(int index, int[] variations)
    {
        if (index == k)
        {
            foreach (int item in variations)
            {
                Console.Write(item);
            }

            Console.WriteLine();
        }
        else
        {
            for (int i = 1; i <= n; i++)
            {
                variations[index] = i;
                GenerateVariations(index + 1, variations);
            }
        }

    }




}

