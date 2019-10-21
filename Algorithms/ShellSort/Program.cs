using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellSort
{
    class Program
    {
        static void Main()
        {

            var array = new char[16] { 'S', 'H', 'E', 'L', 'L', 'S', 'O', 'R', 'T', 'E', 'X', 'A', 'M', 'P', 'L', 'E' };

            var h = 1;

            while (h < array.Length / 3)
            {
                h = 3 * h + 1;
            }

            Console.WriteLine(h);

            while (h >= 1)
            {
                for (int i = h; i < array.Length; i++)
                {
                    for (int j = i; j >= h && (array[j] < array[j - h]); j -= h)
                    {
                        var temp = array[j];
                        array[j] = array[j - h];
                        array[j - h] = temp;
                    }
                }

                h = h / 3;
            }

            Console.WriteLine(string.Join(",", array));

        }
    }
}
