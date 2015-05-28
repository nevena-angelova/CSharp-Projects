/// Write a recursive program that simulates the execution of n nested loops from 1 to n.
/// NOT FINISHED!!!
using System;

namespace NNestedLoops
{
    public class Program
    {

        public static void Main()
        {
            Console.WriteLine("Enter a number:");

            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];

            GenerateCombinations(array, 0);

        }

        public static void GenerateCombinations(int[] array, int index)
        {
            if (index == array.Length)
            {
                Console.WriteLine(String.Join(", ", array));
                return;
            }
            else
            {
                for (int i = 1; i <= array.Length; i++)
                {
                    array[index] = i;
                    GenerateCombinations(array, index + 1);
                }
            }
        }
    }
}