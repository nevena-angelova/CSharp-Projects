using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// Brute-force algorithm
/// </summary>
namespace TripleSum
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] numbers = { 30, -40, -20, -10, 40, 0, 10, 5 };


            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i; j < numbers.Length; j++)
                {
                    for (int k = j; k < numbers.Length; k++)
                    {
                        if (numbers[i] + numbers[j] + numbers[k] == 0)
                        {
                            Console.Write(numbers[i] + ", " + numbers[j] +", "+ numbers[k]);
                        }
                    }
               }

                Console.WriteLine();
            }

        }
    }
}
