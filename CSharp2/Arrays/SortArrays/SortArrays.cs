//Sorting an array means to arrange its elements in increasing order.
//Write a program to sort an array. Use the "selection sort" algorithm: Find the smallest element,
//move it at the first position, find the smallest from the rest, move it at the second position, etc.

using System;

class SortArrays
{
    static void Main(string[] args)
    {
        Console.Write("Enter the array items count N: ");
        int n = int.Parse(Console.ReadLine());

        // fill the array

        int[] myArray = new int[n];

        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            myArray[i] = num;
        }

        // In every term check wether the current item is bigger than the next one, if so exchange their values. 
        // So the bigger number becomes at the end of the array.

        int count = n;

        while (count > 0)
        {
            for (int item = 0; item < count - 1; item++)
            {

                if (myArray[item] > myArray[item + 1])
                {
                    int temp = myArray[item + 1];
                    myArray[item + 1] = myArray[item];
                    myArray[item] = temp;
                }
            }

            // The counter decrease by 1 and the last array item (which is the max one) is not included in the next term.

            count--;
        }

        Console.WriteLine();

        foreach (int member in myArray)
        {
            Console.WriteLine("{0} ", member);
        }
    }
}
