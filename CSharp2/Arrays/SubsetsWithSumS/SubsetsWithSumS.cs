//We are given an array of integers and a number S. Write a program to find if there exists a subset of the elements of the array that has a sum S. Example:
//arr={2, 1, 2, 4, 3, 5, 2, 6}, S=14  yes (1+2+5+6)

using System;

class SubsetsWithSumS
{

    static void Main()
    {

        int[] myArray = { 2, 1, 2, 4, 3, 5, 2, 6 };
        int n = myArray.Length;
        int s = 14;

        int maxI = 1;

        for (int m = 1; m <= n; m++)
        {
            maxI *= 2;
        }

        maxI -= 1;

        int count = 0;

        for (int i = 1; i <= maxI; i++)
        {
            int sum = 0;

            for (int j = 0; j < n; j++)
            {
                int mask = 1 << j;
                int maskAndI = mask & i;
                int bit = maskAndI >> j;

                if (bit == 1)
                {
                    sum += myArray[j];
                }
            }

            if (sum == s)
            {
                count++;
            }
        }

        if (count > 0)
        {
            Console.WriteLine("Yes, the sums are {0}", count);
        }
        else
        {
            Console.WriteLine("No");
        }

   }


}

