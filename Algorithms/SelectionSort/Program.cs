using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class Program
    {
        static void Main()
        {

            int[] numbers = new int[10] { 14, 3, 22, 7, 11, 3, 4, 1, 0, 26 };

            int min = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i; j < numbers.Length; j++)
                {
                    if (numbers[j] < numbers[i])
                    {
                        int temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }

            }


            Console.WriteLine(string.Join(",", numbers));



        }


    }
}
