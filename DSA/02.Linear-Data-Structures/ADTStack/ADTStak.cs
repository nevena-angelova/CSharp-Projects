using System;
using System.Collections;
using System.Collections.Generic;

public class ADTStak<T> : IEnumerable<T>
{
    private const int InitialCapacity = 5;
    private T[] array;
    private int counter;

    public ADTStak(int capacity)
    {
        this.array = new T[capacity];
    }

    public ADTStak()
        : this(InitialCapacity)
    {
    }

    public int Count
    {
        get { return this.counter; }
    }

    public int Capacity
    {
        get { return this.array.Length; }
    }

    public void Push(T element)
    {
        if (this.counter == this.array.Length)
        {
            this.DuplicateCapacity();
        }

        this.array[this.counter] = element;
        this.counter++;
    }

    public T Peek()
    {
        if (this.counter == 0)
        {
            throw new ArgumentException("The stack is empty");
        }

        T objectToReturn = this.array[this.counter - 1];
        return objectToReturn;
    }

    public T Pop()
    {
        this.counter--;
        return this.Peek();
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = this.counter - 1; i >= 0; i--)
        {
            yield return this.array[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }

    private void DuplicateCapacity()
    {
        T[] newArray = new T[2 * this.array.Length];
        Array.Copy(this.array, newArray, this.array.Length);
        this.array = newArray;
    }
}
