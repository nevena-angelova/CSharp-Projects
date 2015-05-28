//Write a program that reads three integer numbers N, K and S and an array of N elements from the console.
//Find in the array a subset of K elements that have sum S or indicate about its absence.

using System;

class SubsetsWithSumSOfKEleme
{

    static void Main()
    {

        int[] myArray = { 2, 1, 2, 4, 3, 5, 2, 6 };
        int n = myArray.Length;
        int s = 14;
        int k = 4;

        int maxI = 1;

        for (int m = 1; m <= n; m++)
        {
            maxI *= 2;
        }

        maxI -= 1;

        int sumCount = 0;
        
        for (int i = 1; i <= maxI; i++)
        {
            int sum = 0;
            int elementCount = 0;

            for (int j = 0; j < n; j++)
            {
                int mask = 1 << j;
                int maskAndI = mask & i;
                int bit = maskAndI >> j;

                if (bit == 1)
                {
                    sum += myArray[j];
                    elementCount++;
                }
            }

            if (sum == s && elementCount == k)
            {
                sumCount++;
            }
        }

        if (sumCount > 0)
        {
            Console.WriteLine("Yes, the sums are {0}", sumCount);
        }
        else
        {
            Console.WriteLine("No");
        }

    }
}


