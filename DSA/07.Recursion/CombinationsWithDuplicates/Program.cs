using System;

namespace CombinationsWithDuplicates
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter N:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter K:");
            int k = int.Parse(Console.ReadLine());

            int[] array = new int[k];

            GenerateCombinations(array, n, 0);

        }

        public static void GenerateCombinations(int[] array, int n, int index)
        {
            int start;

            if (index == array.Length)
            {
                Console.WriteLine(String.Join(", ", array));
            }
            else
            {
                if (index != 0)
                {
                    start = array[index - 1];
                }
                else
                {
                    start = 1;
                }

                for (int i = start; i <= n; i++)
                {
                    array[index] = i;
                    GenerateCombinations(array, n, index + 1);
                }
            }
        }
    }
}
