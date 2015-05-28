//Write a program that finds in given array of integers a sequence of given sum S (if present).
//Example: {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}

using System;

class SequenceSum
{
    static void Main()
    {
        Console.Write("Enter the array items count N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter the sum S: ");
        int s = int.Parse(Console.ReadLine());

        int[] myArray = new int[n];
        int currentSum;
        int withItem;
        int lastItem = 0;
        bool isSum = false;

        // fill the array

        Console.WriteLine("Enter the array items: ");

        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            myArray[i] = num;
        }

        // check the currentSum of every array item with the next ones...

        for (int item = 0; item < n - 1; item++)
        {
            currentSum = myArray[item];

            for (withItem = item + 1; withItem < n; withItem++)
            {
                currentSum += myArray[withItem];

                // ... if currentSum = the given sum, the lastItem becomes the current withItem and the current sub term breaks.

                if (currentSum == s)
                {
                    isSum = true;
                    lastItem = withItem;
                    break;
                }
            }

            // prints all the sequences of the given sum (they could be more than one)

            if (isSum)
            {
                Console.WriteLine();

                for (int j = item; j <= lastItem; j++)
                {
                    Console.WriteLine(myArray[j]);
                }

                isSum = false;
            }
        }


    }
}

