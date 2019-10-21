using LinkedList;

namespace Queues
{
    public class LinkedQueueOfStrings<T>
    {
        private Node<T> first = null;

        private Node<T> last;

        public bool IsEmpty()
        {
            return first == null;
        }

        public void Enqueue(T item)
        {
            if (IsEmpty())
            {
                last = new Node<T>(null, item);
                first = last;
            }
            else
            {
                var newNode = new Node<T>(null, item);
                last.Next = newNode;
                last = newNode;
            }

        }

        public T Dequeue()
        {
            var item = first.Item;

            first = first.Next;

            if (IsEmpty())
            {
                last = null;
            }

            return item;
        }

    }
}
