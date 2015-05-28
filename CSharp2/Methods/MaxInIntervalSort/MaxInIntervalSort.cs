// Write a method that return the maximal element in a portion of array of integers starting at given index.
// Using it write another method that sorts an array in ascending / descending order.
using System;

class MaxInIntervalSort
{
    static void Main()
    {
        int[] myArray = { -17, 1, 2, 9, -2, 18, 16, 7, 3, 4, 11 };
        int index = 4;

        int max = FindMax(index, myArray);
        Console.WriteLine(max);

        SortInOrder(myArray);
    }

    // Check wether the current item is bigger than the next one, if so exchange their values.
    // So the bigger number becomes at the end of the array.

    static int FindMax(int index, int[] array)
    {
        int arrLenght = array.Length;

        for (int i = index; i < arrLenght - 1; i++)
        {
            if (array[i] > array[i + 1])
            {
                int temp = array[i + 1];
                array[i + 1] = array[i];
                array[i] = temp;
            }
        }

        return array[arrLenght - 1];
    }

    static void SortInOrder(int[] array)
    {
        int arrLenght = array.Length;
        int count = array.Length;

        // applies FindMax() array.Length times

        while (count > 0)
        {
            FindMax(0, array);
            count--;
        }

        // reverse the sorted array

        int[] reversed = new int[arrLenght];

        for (int i = 0; i < arrLenght; i++)
        {
            reversed[i] = array[arrLenght - 1 - i];
        }

        //print the two arrays

        Print(array);
        Print(reversed);
    }

    // print method

    static void Print(int[] array)
    {
        foreach (int item in array)
        {
            Console.Write("{0} ", item);
        }
        Console.WriteLine();
    }
}

