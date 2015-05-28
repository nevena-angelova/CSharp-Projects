//Write a program that finds the sequence of maximal sum in given array. Example:
//{2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4}
//Can you do it with only one loop (with single scan through the elements of the array)?

using System;

class MaxSum
{
    static void Main()
    {
        Console.Write("Enter the array items count N: ");
        int n = int.Parse(Console.ReadLine());

        int[] myArray = new int[n];

        int maxSum = int.MinValue;
        int sum = 0;
        int firstMaxItem = 0; //the first member of the max sequence
        int lastMaxItem = 0; //the last member of the max sequence

        // fill the array

        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            myArray[i] = num;
        }

        // check wether the current sum is > 0, if so add another item to it,
        // otherwise sum = 0 and the firstMaxItem becomes the next array item.

        for (int item = 0; item < n; item++)
        {
            if (sum + myArray[item] > 0)
            {
                sum += myArray[item];
            }
            else
            {
                sum = 0;
                firstMaxItem = item + 1;
            }

            // ... check the sum and if true change the condition and the current item becomes lastMaxItem.

            if (sum > maxSum)
            {
                maxSum = sum;
                lastMaxItem = item;
            }
        }

        Console.WriteLine("The max sum is: {0}", maxSum);

        Console.WriteLine("The sequence is:");

        for (int j = firstMaxItem; j <= lastMaxItem; j++)
        {
            Console.WriteLine("{0} ", myArray[j]);
        }
    }
}
