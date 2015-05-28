// * Modify your last program and try to make it work for any number type, not just integer (e.g. decimal, float, byte, etc.).
// Use generic method (read in Internet about generic methods in C#).
using System;

class GenericMathOperations
{
    static void Main()
    {
        Console.WriteLine("How many numbers will be in the set?");
        int n = int.Parse(Console.ReadLine());

        double[] set = new double[n];

        Console.WriteLine("Enter the numbers:");

        for (int i = 0; i < n; i++)
        {
            set[i] = double.Parse(Console.ReadLine());
        }

        Console.WriteLine("The minimal number is: {0}", Min(set));
        Console.WriteLine("The maximal number is: {0}", Max(set));
        Console.WriteLine("The average is: {0}", Average(set));
        Console.WriteLine("The sum is: {0}", Sum(set));
        Console.WriteLine("The product is: {0}", Product(set));
    }

    static T Min<T>(T[] array)
    {
        dynamic min = array[0];

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
            }
        }

        return min;

    }

    static T Max<T>(T[] array)
    {
        dynamic max = array[0];

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }

        return max;
    }

    static T Sum<T>(T[] array)
    {
        dynamic sum = 0;

        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }

        return sum;
    }

    static double Average<T>(T[] array)
    {

        double average = Convert.ToDouble(Sum(array)) / array.Length;

        return average;
    }

    static T Product<T>(T[] array)
    {
        dynamic product = 1;

        for (int i = 0; i < array.Length; i++)
        {
            product *= array[i];
        }

        return product;
    }
}

