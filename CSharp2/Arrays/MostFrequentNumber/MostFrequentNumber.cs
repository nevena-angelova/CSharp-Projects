//Write a program that finds the most frequent number in an array. Example:
//{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)

using System;

class MostFrequentNumber
{
    static void Main()
    {
        Console.Write("Enter the array items count N: ");
        int n = int.Parse(Console.ReadLine());

        int[] myArray = new int[n];

        int mostFrequentCount = int.MinValue;
        int mostFrequentNum = 0;
        int currentCount = 0;

        // fill the array

        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            myArray[i] = num;
        }

        // check wether the j-th item is equal to each one of the array items after it.
        // if so currentCount++ and if it is > than mostFrequentCount exchange their values
        // and mostFrequentNum becames the current array item which is compared to the j-th item.

        for (int j = 0; j < n - 1; j++)
        {
            currentCount = 1;

            for (int k = j + 1; k < n; k++)
            {
                if (myArray[j] == myArray[k])
                {
                    currentCount++;

                    if (currentCount > mostFrequentCount)
                    {
                        mostFrequentCount = currentCount;
                        mostFrequentNum = myArray[k];
                    }
                }
            }
        }

        if (currentCount > 0)
        {
            Console.WriteLine("{0}({1} times)", mostFrequentNum, mostFrequentCount);
        }
        else
        {
            Console.WriteLine("There are not frequent numbers.");
        }

    }
}