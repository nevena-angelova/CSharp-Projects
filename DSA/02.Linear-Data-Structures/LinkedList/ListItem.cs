using System;

public class ListItem<T>
{
    public ListItem(T value)
    {
        this.Value = value;
        this.NextItem = null;
        this.Previous = null;
    }

    public T Value { get; set; }

    public ListItem<T> NextItem { get; set; }

    public ListItem<T> Previous { get; set; }
}