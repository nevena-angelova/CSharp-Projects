//Write a program that reads two arrays from the console and compares them element by element.
using System;

class Compare
{
    static void Main()
    {
        Console.WriteLine("Enter how many array elements will be: ");
        int n = int.Parse(Console.ReadLine());
        bool isEqual = true;

        int[] firstArray = new int[n];
        int[] secondArray = new int[n];

        Console.WriteLine("Enter numbers for the first array:");

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("At position {0}:", i);
            firstArray[i] = int.Parse(Console.ReadLine());

        }

        Console.WriteLine("Enter numbers for the second array:");

        for (int j = 0; j < n; j++)
        {
            Console.WriteLine("At position {0}:", j);

            int secondArrItem = int.Parse(Console.ReadLine());

            if (firstArray[j] == secondArrItem)
            {
                secondArray[j] = secondArrItem;
            }
            else
            {
                Console.WriteLine("The two arrays are not equal.");
                isEqual = false;
                break;
            }
        }

        if (isEqual)
        {
            Console.WriteLine("The two arrays are equal.");
        }
    }
}

