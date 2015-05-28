// Write a program, that reads from the console an array of N integers and an integer K,
// sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.

// The solution is according to this: http://msdn.microsoft.com/en-us/library/2cy9f6wb.aspx

using System;

class BinarySearchValues
{
    // prints the array

    static void PrintArray(int[] array)
    {
        foreach (int item in array)
        {
            Console.Write("{0} ", item);
        }
        Console.WriteLine();
    }

    static void Main()
    {
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("K = ");
        int k = int.Parse(Console.ReadLine());

        int[] myArray = new int[n];

        // fill the array

        Console.WriteLine("Enter the array elements:");

        for (int i = 0; i < n; i++)
        {
            myArray[i] = int.Parse(Console.ReadLine());
        }

        PrintArray(myArray);

        // sort the array

        Array.Sort(myArray);

        PrintArray(myArray);

        // "index" takes the result from BinarySearch method.

        int index = Array.BinarySearch(myArray, k);

        if (index == -1)
        {
            Console.WriteLine("\"k\" is smaller than all of the elements.");
        }

        // when "index" is < -1 it points at the element that is the next bigger than "k", so it is reversed

        else if (index < -1)
        {
            index = ~index - 1;
            Console.WriteLine("The largest number, smaller than {0} is {1} with index {2}", k, myArray[index], index);
        }
        else if (index >= 0)
        {
            Console.WriteLine("Number {0} is in the array, with index {1}", k, index);
        }
    }
}

