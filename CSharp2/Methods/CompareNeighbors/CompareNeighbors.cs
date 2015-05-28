using System;

class CompareNeighbors
{
    static void Main()
    {
        int[] myArray = { 17, 17, 3, 1, 14, 3, 1, 5, 23, 3, 18, 18 };
        int position = 4;
        
        CompareNumber(myArray, position);
    }

    static void CompareNumber(int[] array, int position)
    {
        if (position == 0 && array[position] > array[position + 1])
        {
            Console.WriteLine("Yes");
        }
        else if (position == array.Length - 1 && array[position] > array[position - 1])
        {
            Console.WriteLine("Yes");
        }
        else if ((position != 0) && (position != array.Length-1) && (array[position] > array[position + 1] && array[position] > array[position - 1]))
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}


