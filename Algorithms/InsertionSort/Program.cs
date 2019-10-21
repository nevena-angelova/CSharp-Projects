using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    class Program
    {
        static void Main()
        {
            int[] numbers = new int[10] { 14, 3, 22, 7, 11, 3, 4, 1, 0, 26 };

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (numbers[j] < numbers[j - 1])
                    {
                        var temp = numbers[j];
                        numbers[j] = numbers[j-1];
                        numbers[j-1] = temp;
                    }
                }
            }


            Console.WriteLine(string.Join(",", numbers));
        }
    }
}
