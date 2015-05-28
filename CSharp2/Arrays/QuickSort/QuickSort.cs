//Write a program that sorts an array of strings using the quick sort algorithm (find it in Wikipedia).

using System;

class Program
{

    private static void QuickSort(int[] array, int left, int right)
    {

        int i = left;
        int j = right;
        int pivot = array[(left + right) / 2];

        // arrange the elements that are smaller than the pivot at the left side and the bigger at right by replasing their places only if
        // the i-th element is bigger than the pivot and the j-th element is smaller than the pivot. Otherwise the elements are skiped.
        // the comparison incudes the pivot itself.

        while (i <= j)
        {
            while (array[i] < pivot)
                i++;
            while (array[j] > pivot)
                j--;
            if (i <= j)
            {
                int tmp = array[i];
                array[i++] = array[j];
                array[j--] = tmp;
            }
        }

        // here i <= j (they are placed somewhere in the middle). QuickSort is applied recursively at first at the left side, by separating
        // it at another 2 pieces, then again to the left side of the left piece and so on till j > left.
        // Then QuickSort is applied at the last parted piece's right side and so on.

        if (j > left)
        {
            QuickSort(array, left, j);
        }
        if (i < right)
        {
            QuickSort(array, i, right);
        }
    }


    static void Main()
    {
        int[] myArray = { 1, 8, 14, 12, 7, 23, 15, 13 };

        int size = myArray.Length;

        foreach (int item in myArray)
        {
            Console.Write("{0} ", item);
        }
        Console.WriteLine();

        QuickSort(myArray, 0, size - 1);

        foreach (int item in myArray)
        {
            Console.Write("{0} ", item);
        }
        Console.WriteLine();
    }





}
