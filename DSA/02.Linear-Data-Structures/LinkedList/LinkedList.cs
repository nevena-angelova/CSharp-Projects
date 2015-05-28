using System;
using System.Collections;
using System.Collections.Generic;

public class LinkedList<T> : IEnumerable<T>
{
    private ListItem<T> Head { get; set; }

    private ListItem<T> Tail { get; set; }

    public void AddLast(T value)
    {
        var newNode = new ListItem<T>(value);

        if (this.Head == null && this.Tail == null)
        {
            this.Head = newNode;
            this.Tail = newNode;
        }
        else
        {
            this.Tail.NextItem = newNode;
            newNode.Previous = this.Tail;
            this.Tail = newNode;
        }
    }

    public IEnumerator<T> GetEnumerator()
    {
        var node = this.Head;
        while (node != null)
        {
            yield return node.Value;
            node = node.NextItem;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}
