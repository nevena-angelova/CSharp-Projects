using System;

namespace CombinationsWithoutDuplications
{
    class Program
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
                Console.WriteLine(String.Join(", ", combinations));
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
}
