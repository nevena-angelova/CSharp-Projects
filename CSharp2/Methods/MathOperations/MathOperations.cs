// Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers. Use variable number of arguments.
using System;

class MathOperations
{
    static void Main()
    {
        Console.WriteLine("How many numbers will be in the set?");
        int n = int.Parse(Console.ReadLine());

        int[] set = new int[n];

        Console.WriteLine("Enter the numbers:");

        for (int i = 0; i < n; i++)
        {
            set[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("The minimal number is: {0}", Min(set));
        Console.WriteLine("The maximal number is: {0}", Max(set));
        Console.WriteLine("The average is: {0}", Average(set));
        Console.WriteLine("The sum is: {0}", Sum(set)); 
        Console.WriteLine("The product is: {0}", Product(set));
    }

    static int Min(int[] array)
    {
        int min = int.MaxValue;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
            }
        }

        return min;
    }

    static int Max(int[] array)
    {
        int max = int.MinValue;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }

        return max;
    }

    static int Sum(int[] array)
    {
        int sum = 0;

        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }

        return sum;
    }

    static double Average(int[] array)
    {
        double average = (double)Sum(array) / array.Length;

        return average;
    }

    static int Product(int[] array)
    {
        int product = 1;

        for (int i = 0; i < array.Length; i++)
        {
            product *= array[i];
        }

        return product;
    }
}

