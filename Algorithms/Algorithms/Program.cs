using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var uf = new UF(numbers);

            uf.Connect(1, 6);
            uf.Connect(1, 9);
            uf.Connect(6, 4);

            Console.WriteLine(uf.AreConnected(1, 6));


            uf.Print();

        }
    }
}
