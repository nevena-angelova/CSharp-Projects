using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickUnion
{
    public class QU
    {
        private int[] numbers;

        public QU(int[] input)
        {
            numbers = input;
        }

        public bool IsRoot(int x)
        {
            return numbers[x] == x;
        }

        public int Root(int x)
        {
            while (!IsRoot(x))
            {
                x = numbers[x];
            }

            return x;
        }

        public void Connect(int a, int b)
        {
            int aRoot = Root(a);
            int bRoot = Root(b);

            numbers[aRoot] = bRoot;
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
