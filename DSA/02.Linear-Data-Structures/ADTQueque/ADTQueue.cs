using System;
using System.Collections.Generic;

public class ADTQueue<T>
{
    private LinkedList<T> list;

    public ADTQueue()
    {
        this.list = new LinkedList<T>();
    }

    public int Count
    {
        get
        {
            return this.list.Count;
        }
    }

    public void Enqueue(T item)
    {
        this.list.AddLast(item);
    }

    public T Peek()
    {
        if (this.list.Count == 0)
        {
            throw new ArgumentException("The queue is empty!");
        }

        return this.list.First.Value;
    }

    public T Dequeue()
    {
        T firstItem = this.Peek();
        this.list.RemoveFirst();
        return firstItem;
    }
}
