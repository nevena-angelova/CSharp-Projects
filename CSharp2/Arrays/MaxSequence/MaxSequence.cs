//Write a program that finds the maximal sequence of equal elements in an array.
//Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1}  {2, 2, 2}.

using System;

class MaxSequence
{
    static void Main()
    {
        Console.Write("Enter the array items count: ");
        int n = int.Parse(Console.ReadLine());

        int count = 0;
        int previous = 0;
        int max = int.MinValue;
        int maxNum = 0;

        int[] myArray = new int[n];

        // fill the array

        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            myArray[i] = num;
        }

        // find the maximum sequence by checking whether the previous member of the area is equal to the current.

        for (int j = 0; j < n; j++)
        {
            if (j == 0)
            {
                previous = myArray[j];
            }
            else if (myArray[j] == previous)
            {
                count++;

                if (count > max)
                {
                    max = count;
                    maxNum = myArray[j];
                }
            }
            else
            {
                count = 0;
            }

            previous = myArray[j];
        }

        Console.Write("The maximal sequence of equal elements is: ");

        // prints the last of the equal elements "max" times

        for (int k = 0; k <= max; k++)
        {
            Console.Write(" {0}", maxNum);
        }

        Console.WriteLine();
    }
}

