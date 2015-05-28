// Write a program that sorts an array of integers using the merge sort algorithm (find it in Wikipedia).

// For the solution is used: http://www.youtube.com/watch?v=M814OagXWTI

using System;

class Program
{

    // "MergeSort" creates new left (bArray) and right (cArray) sub arrays with size = half of the main array's size.
    // Everytime MergeSort is called recursively the main array's size becomes equal to the the left's or right's subarray size.
    // So the main array is devided by smaller and smaller pieces till the bottom is reached, then "Merge" is called.

    static void MergeSort(int[] aArray)
    {
        int n = aArray.Length;
        int half = (n / 2);


        int[] bArray = new int[half];
        int[] cArray = new int[n - half];

        if (n > 1)
        {
            for (int b = 0; b < half; b++)
            {
                bArray[b] = aArray[b];

            }
            for (int c = 0; c < n - half; c++)
            {
                cArray[c] = aArray[c + half];
            }


            MergeSort(bArray);
            MergeSort(cArray);
            Merge(bArray, cArray, aArray, half, n);
        }

    }

    // "Merge" compares one by one the elements from the left and the rigth subarray.
    // If the current element is smaller than the relevant in the other array, it is recorded in the main array.
    // If i=half, the next element in the main array (k) becomes the j-th from the right subarray, otherwise - the i-th from the left.

    static void Merge(int[] bArray, int[] cArray, int[] aArray, int half, int n)
    {
        int i = 0;
        int j = 0;
        int k = 0;

        while ((i < half) && (j < n - half))
        {
            if (bArray[i] <= cArray[j])
            {
                aArray[k] = bArray[i];
                i++;
            }
            else
            {
                aArray[k] = cArray[j];
                j++;
            }

            k++;

            if (i == half)
            {
                aArray[k] = cArray[j];
            }
            else
            {
                aArray[k] = bArray[i];
            }

        }

        // if the one subarray is empty but in the other there are elements left,
        // fills the main array with the elements that are left.

        while (i < half)
        {
            aArray[k] = bArray[i];
            i++;
            k++;
        }
        while (j < n - half)
        {
            aArray[k] = cArray[j];
            j++;
            k++;
        }

    }

    static void Main()
    {
        int[] myArray = { 8, 3, 2, 9, 7, 1};

        MergeSort(myArray);

        foreach (int item in myArray)
        {
            Console.Write("{0} ", item);
        }
        Console.WriteLine();


    }

}

