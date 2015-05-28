using System;
using System.Collections.Generic;

namespace PriorityQueueImplementation
{
    public class PriorityQueue<T> where T : IComparable<T>
    {
        private List<T> items;

        public PriorityQueue()
        {
            this.items = new List<T>();
        }

        public List<T> Items
        {
            get { return this.items; }
        }

        public void Enqueue(T value)
        {
            this.items.Add(value);

            int childIndex = this.items.Count - 1;

            while (childIndex > 0)
            {
                int parentIndex = (childIndex - 1) / 2;
                if (this.items[parentIndex].CompareTo(this.items[childIndex]) >= 0)
                {
                    break;
                }

                T swap = this.items[childIndex];
                this.items[childIndex] = this.items[parentIndex];
                this.items[parentIndex] = swap;

                childIndex = parentIndex;
            }
        }
    }
}
