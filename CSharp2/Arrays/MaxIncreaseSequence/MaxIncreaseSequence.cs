//Write a program that finds the maximal increasing sequence in an array. Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.

using System;

class MaxIncreaseSequence
{
    static void Main()
    {
        Console.Write("Enter the array items count: ");
        int n = int.Parse(Console.ReadLine());

        int count = 0;
        int previous = 0;
        int max = int.MinValue;
        int maxSeqNum = 0;

        int[] myArray = new int[n];

        // fill the array

        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            myArray[i] = num;
        }

        // find the maximum increasing sequence by checking whether the previous member of the area is equal to the current - 1.

        for (int j = 0; j < n; j++)
        {
            if (j == 0)
            {
                previous = myArray[j];
            }
            else if (myArray[j] - 1 == previous)
            {
                count++;

                if (count > max)
                {
                    max = count;
                    maxSeqNum = myArray[j];
                }
            }
            else
            {
                count = 0;
            }

            previous = myArray[j];
        }

        Console.Write("The maximal sequence of equal elements is: ");

        // prints the last of the equal elements - k "max" times

        for (int k = max; k >= 0; k--)
        {
            Console.Write(" {0}", maxSeqNum - k);
        }

        Console.WriteLine();
    }
}

