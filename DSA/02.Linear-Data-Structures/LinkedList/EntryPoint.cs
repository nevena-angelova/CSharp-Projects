/// Implement the data structure linked list. Define a class ListItem<T> that has two fields:
/// value (of type T) and NextItem (of type ListItem<T>). Define additionally a class LinkedList<T>
/// with a single field FirstElement (of type ListItem<T>).
using System;
using System.Collections.Generic;

public class EntryPoint
{
    public static void Main()
    {
        LinkedList<int> linkedList = new LinkedList<int>();
        linkedList.AddLast(23);
        linkedList.AddLast(11);
        linkedList.AddLast(7);
        linkedList.AddLast(1);

        foreach (int item in linkedList)
        {
            Console.WriteLine(item);
        }
    }
}
