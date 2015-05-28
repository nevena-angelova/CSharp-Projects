using System;
using System.Collections.Generic;

namespace Factor
{
    class Program
    {
        static List<int> result = new List<int>();

        static void Main()
        {
            int numbersCount = int.Parse(Console.ReadLine());
            int[] numbers = new int[numbersCount];

            for (int i = 0; i < numbersCount; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(numbers);

            string numbersString = numbers.ToString();

            Console.WriteLine(numbersString);




            GeneratePermutations(numbers, 1);


            //int resultNumber = FindMinFactor(result);

            //Console.WriteLine(resultNumber);



        }

        static int Factor(int number)
        {
            int counter = 0;

            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    counter++;
                }
            }

            return counter;
        }

        static int FindMinFactor(List<int> numbers)
        {
            int minFactor = Factor(numbers[0]);
            int currentFactor;
            int minFactorNumber = 0;

            for (int i = 1; i < numbers.Count; i++)
            {
                currentFactor = Factor(numbers[i]);

                if (currentFactor < minFactor)
                {
                    minFactor = currentFactor;
                    minFactorNumber = numbers[i];
                }
            }

            return minFactorNumber;
        }

        static void GeneratePermutations(int[] numbers, int k)
        {
            if (k >= numbers.Length)
                throw new NotImplementedException();
                //result.Add(numbers);
            else
            {
                GeneratePermutations(numbers, k + 1);
                for (int i = k + 1; i < numbers.Length; i++)
                {
                    Swap(numbers[k], numbers[i]);
                    GeneratePermutations(numbers, k + 1);
                    Swap(numbers[k], numbers[i]);
                }
            }
        }

        static void Swap(int first, int second)
        {
            int temp = first;
            first = second;
            second = temp;
        }
    }
}