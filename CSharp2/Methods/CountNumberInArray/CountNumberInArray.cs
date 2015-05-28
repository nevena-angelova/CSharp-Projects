// Write a method that counts how many times given number appears in given array.
// Write a test program to check if the method is working correctly.

using System;

class CountNumberInArray
{
    static void Main()
    {
        int[] myArray = { 2, 3, 3, 17, 4, 3, 8, 5, 5, 3, 6, 8 };

        int number = 3;

        CountNumber(myArray, number);
    }

    static void CountNumber(int[] array, int num)
    {
        int counter = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == num)
            {
                counter++;
            }
        }

        Console.WriteLine(counter);
    }
}

