using System;
using System.Collections;
using System.Collections.Generic;

class LinkedStack<T> : IEnumerable<T> 
{
    private StackItem<T> Head { get; set; }

    public void Push(T value)
    {
        StackItem<T> newItem = new StackItem<T>(value);

        newItem.NextItem = this.Head;
        this.Head = newItem;
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

