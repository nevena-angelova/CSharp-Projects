using System;

namespace PriorityQueueImplementation
{
    class Program
    {
        static void Main()
        {
            PriorityQueue<int> numbers = new PriorityQueue<int>();

            numbers.Enqueue(5);
            numbers.Enqueue(13);
            numbers.Enqueue(8);
            numbers.Enqueue(3);
            numbers.Enqueue(20);
            numbers.Enqueue(6);

            for (int i = 0; i < numbers.Items.Count; i++)
            {
                Console.WriteLine(numbers.Items[i]);
            }

        }
    }
}
