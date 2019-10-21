using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues
{
    class Program
    {
        static void Main()
        {
            //var queue = new LinkedQueueOfStrings();

            var queue = new ResizingArrayQueueOfStrings<string>();

            queue.Enqueue("To");

            queue.Enqueue(" be");

            queue.Enqueue(" or");

            queue.Enqueue(" not");

            queue.Enqueue(" to");

            queue.Enqueue(" be.");


            while (!queue.IsEmpty())
            {
                Console.WriteLine(queue.Dequeue());
            }





        }
    }
}
