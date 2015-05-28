/// Write a program that counts in a given array of double values the number of occurrences of each value.
/// Use Dictionary<TKey,TValue>.
namespace CountValues
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            double[] numbers = new double[] { 3, 4, 4, -2.5, 3, 3, 4, 3, -2.5 };

            Dictionary<double, int> numberCount = new Dictionary<double, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numberCount.ContainsKey(numbers[i]))
                {
                    numberCount[numbers[i]]++;
                }
                else
                {
                    numberCount.Add(numbers[i], 1);
                }
            }

            foreach (KeyValuePair<double, int> pair in numberCount.OrderBy(p => p.Key))
            {
                Console.WriteLine("{0} -> {1} times", pair.Key, pair.Value);
            }
        }
    }
}
