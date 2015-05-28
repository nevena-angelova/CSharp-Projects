//2. Implement a set of extension methods for IEnumerable<T> that implement the following group functions:
//sum, product, min, max, average.

using System;
using System.Collections.Generic;
using System.Linq;

namespace IEnumerableExtension
{
    public static class Extension
    {
        public static decimal Sum<T>(this IEnumerable<T> collection)
        {
            decimal sum = 0;

            foreach (T item in collection)
            {
                sum += Convert.ToDecimal(item);
            }

            return sum;
        }

        public static decimal Product<T>(this IEnumerable<T> collection)
        {
            decimal product = 1;

            foreach (T item in collection)
            {
                product *= Convert.ToDecimal(item);
            }

            return product;
        }

        public static T Max<T>(this IEnumerable<T> collection) where T : IComparable
        {
            T max = collection.ElementAt(0);

            foreach (T item in collection)
            {
                if (item.CompareTo(max) > 0)
                {
                    max = item;
                }
            }

            return max;
        }

        public static T Min<T>(this IEnumerable<T> collection) where T : IComparable
        {
            T min = collection.ElementAt(0);

            foreach (T item in collection)
            {
                if (item.CompareTo(min) < 0)
                {
                    min = item;
                }
            }

            return min;
        }

        public static decimal Average<T>(this IEnumerable<T> collection)
        {
            return collection.Sum() / collection.Count();
        }
    }


    class Program
    {
        static void Main()
        {
            List<int> list = new List<int>() { 23, 100, -2, -11, 34, -20, 4, 1, 53, 72, 6 };

            Console.WriteLine("The sum is: {0}", list.Sum());
            Console.WriteLine("The product is: {0}", list.Product());
            Console.WriteLine("The max item is: {0}", list.Max());
            Console.WriteLine("The min item is: {0}", list.Min());
            Console.WriteLine("The average is: {0}", list.Average());
        }
    }
}
