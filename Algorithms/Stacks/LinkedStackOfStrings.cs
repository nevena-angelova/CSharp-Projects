using LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks
{
    public class LinkedStackOfStrings<T>
    {
        public Node<T> first = null;

        public bool IsEmpty()
        {
            return first == null;
        }

        public void Push(T item)
        {
            Node<T> newNode = new Node<T>(first, item);
            first = newNode;
        }

        public T Pop()
        {
            var item = first.Item;
            first = first.Next;
            return item;
        }

    }
}
