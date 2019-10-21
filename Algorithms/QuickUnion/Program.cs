using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickUnion
{
    class Program
    {
        static void Main()
        {
            int[] numbers = { 1, 1, 1, 8, 3, 0, 5, 1, 8, 8 };

            var qu = new QU(numbers);

            Console.WriteLine(qu.Root(3));


            qu.Connect(1,8);

            qu.Print();


        }
    }
}
