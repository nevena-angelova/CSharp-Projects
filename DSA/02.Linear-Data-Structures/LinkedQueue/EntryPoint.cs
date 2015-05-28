using System;

class EntryPoint
{
    static void Main()
    {

        LinkedStack<int> queue = new LinkedStack<int>();
        queue.Push(23);
        queue.Push(17);
        queue.Push(4);
        queue.Push(5);

        foreach (int item in queue)
        {
            Console.WriteLine(item);
        }

    }
}

