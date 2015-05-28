/// Implement the ADT queue as dynamic linked list. Use generics (LinkedQueue<T>) to allow storing different data types in the queue.
using System;

public class EntryPoint
{
   public static void Main()
    {
        ADTQueue<int> numbers = new ADTQueue<int>();
        numbers.Enqueue(12);
        numbers.Enqueue(1);
        numbers.Enqueue(2);
        numbers.Enqueue(44);
        numbers.Enqueue(13);

        numbers.Dequeue();

        Console.WriteLine(numbers.Peek());
    }
}