//Write a program that finds the index of given element in a sorted array of integers by using
//the binary search algorithm (find it in Wikipedia).

using System;

class BinarySearch
{
    static void Main()
    {

        int[] myArray = { 2, 6, 13, 21, 36, 47, 63, 81, 97 };

        int number = 47;

        bool notInArray = true;
        Array.Sort(myArray);

        int start = 0;
        int end = myArray.Length - 1;


        while (start <= end)
        {
            int middle = (start + end) / 2;

            if (number == myArray[middle])
            {
                Console.WriteLine("{0} is in the array at position {1}", number, middle);
                notInArray = false;
                break;
            }
            else if (number < myArray[middle])
            {
                end = middle - 1;
            }
            else
            {
                start = middle + 1;
            }
        }

        if (notInArray)
        {
            Console.WriteLine("{0} is not in the array.", number);
        }
    }
}

