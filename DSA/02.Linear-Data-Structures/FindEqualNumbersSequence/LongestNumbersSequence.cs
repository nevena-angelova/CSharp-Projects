//Write a method that finds the longest subsequence of equal numbers in given List<int> and returns the result as new List<int>.
//Write a program to test whether the method works correctly.

using System;
using System.Collections.Generic;


namespace FindEqualNumbersSequence
{
   public class EqualNumbersSequence
    {
        static void Main()
        {

            List<int> numbers = new List<int>()
            {
                4, 2, 2, 5, 2, 3, 3, 3, 1, 5, 5, 5, 5
            };

            Console.WriteLine("In {0}: ", String.Join(", ", numbers));
            Console.WriteLine("The longest sequence of equal nimbers is: {0}", String.Join(", ", findSequence(numbers)));
        }

        public static List<int> findSequence(List<int> numbers)
        {
            List<int> longestSequence = new List<int>();

            int counter = 1;
            int tempCounter = 1;
            int repeatedNumber = 0;

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i - 1] == numbers[i])
                {
                    tempCounter++;
                    if (tempCounter > counter)
                    {
                        counter = tempCounter;
                        repeatedNumber = numbers[i];
                    }
                }
                else
                {
                    tempCounter = 1;
                }
            }

            for (int j = 0; j < counter; j++)
            {
                longestSequence.Add(repeatedNumber);
            }

            return longestSequence;
        }
    }
}

