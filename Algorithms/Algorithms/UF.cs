using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class UF
    {

        private int[] numbers;

        public UF(int[] input)
        {
            numbers = input;
        }

        public bool AreConnected(int a, int b)
        {
            return numbers[a] == numbers[b];
        }

        public void Connect(int a, int b)
        {
            if (!AreConnected(a, b))
            {
                int ai = numbers[a];
                int bi = numbers[b];
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] == ai)
                    {
                        numbers[i] = bi;
                    }
                }               
            }
        }

        public void Print()
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + ", ");
            }

            Console.WriteLine();
        }

    }
}
