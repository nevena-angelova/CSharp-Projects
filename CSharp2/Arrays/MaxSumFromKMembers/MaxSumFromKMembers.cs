//Write a program that reads two integer numbers N and K and an array of N elements from the console.
//Find in the array those K elements that have maximal sum.
using System;

class MaxSumFromKMembers
{
    static void Main(string[] args)
    {
        Console.Write("Enter the array items count N: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter the sum items count K (K<N): ");
        int k = int.Parse(Console.ReadLine());

        int[] myArray = new int[n];
        int[] maxSumArray = new int[k];

        int maxSum = int.MinValue;

        // fill the array

        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            myArray[i] = num;
        }

        // for every array element from 0 to n-k ...

        for (int item = 0; item <= n - k; item++)
        {
            int sum = 0;

            // ... add to sum the next k elements ...

            for (int sumItem = 0; sumItem < k; sumItem++)
            {
                sum += myArray[item + sumItem];
            }

            // ... check the sum and if true change the condition and fills maxSumArray
            //     with k items, the first one of which is the current myArray item.

            if (sum > maxSum)
            {
                maxSum = sum;

                for (int maxItem = 0; maxItem < k; maxItem++)
                {
                    maxSumArray[maxItem] = myArray[item + maxItem];
                }
            }
        }

        // prints maxSumArray

        foreach (int item in maxSumArray)
        {
            Console.Write("{0} ", item);
        }

        Console.WriteLine();
    }
}

