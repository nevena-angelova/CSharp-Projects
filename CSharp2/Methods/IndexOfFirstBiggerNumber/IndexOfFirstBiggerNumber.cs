// Write a method that checks if the element at given position in given array of integers is bigger than its two neighbors (when such exist).
using System;

class CompareNeighbors
{
    static void Main()
    {
        int[] myArray = { 1, 2, 3, 4, 11, 13, 14, 15, 28, 23, 3, 1 };

        if (CompareNumber(myArray) == -1)
        {
            Console.WriteLine("There is no such element");
        }
        else
        {
            Console.WriteLine("index = {0}", CompareNumber(myArray));
        }
    }

    static int CompareNumber(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (i == 0 && array[i] > array[i + 1])
            {
                return i;
            }
            if (i == array.Length - 1 && array[i] > array[i - 1])
            {
                return i;
            }
            if ((i != 0) && (i != array.Length - 1) && (array[i] > array[i + 1] && array[i] > array[i - 1]))
            {
                return i;
            }
        }

        return -1;
    }
}


