using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Node<T>
    {
        private T item;

        private Node<T> next;

        public Node(Node<T> next, T item)
        {
            this.item = item;
            this.next = next;
        }

        public T Item
        {
            get { return this.item; }
            set { this.item = value; }
        }

        public Node<T> Next
        {
            get { return this.next; }
            set { this.next = value; }
        }
    }
}
