//Write a program that compares two char arrays lexicographically (letter by letter).

using System;

class CompareChar
{
    static void Main()
    {
        Console.WriteLine("Enter how many array elements will be in the first array: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter how many array elements will be in the second array: ");
        int m = int.Parse(Console.ReadLine());
        bool isEqual = true;

        char[] firstArray = new char[n];
        char[] secondArray = new char[m];

        Console.WriteLine("Enter chars for the first array:");

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("At position {0}:", i);
            firstArray[i] = char.Parse(Console.ReadLine());

        }

        Console.WriteLine("Enter numbers for the second array:");

        for (int j = 0; j < m; j++)
        {
            Console.WriteLine("At position {0}:", j);

            char secondArrItem = char.Parse(Console.ReadLine());

            if (firstArray[j] == secondArrItem)
            {
                secondArray[j] = secondArrItem;
            }
            else if (firstArray[j] > secondArrItem)
            {
                Console.WriteLine("The second array is lexicographically earlier.");
                isEqual = false;
                break;
            }
            else
            {
                Console.WriteLine("The first array is lexicographically earlier.");
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

