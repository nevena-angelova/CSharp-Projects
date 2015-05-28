using System;

public class StackItem<T>
{
    public StackItem(T value)
    {
        this.Value = value;
        this.NextItem = null;
    }

    public T Value { get; set; }

    public StackItem<T> NextItem { get; set; }
}

