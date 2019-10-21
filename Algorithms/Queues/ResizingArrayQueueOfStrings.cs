namespace Queues
{
    public class ResizingArrayQueueOfStrings<T>
    {
        private T[] items;

        private int head;

        private int tail;

        public ResizingArrayQueueOfStrings()
        {
            items = new T[1];
        }

        public bool IsEmpty()
        {
            return head == tail;
        }

        private void Resize(int size)
        {
            var newArr = new T[size];

            var len = tail - head;
            for (int i = 0; i < len; i++)
            {
                newArr[i] = items[i + head];
            }

            items = newArr;           

            head = 0;
            tail = len;
        }

        public void Enqueue(T item)
        {
            if (items.Length == tail)
            {
                Resize(tail * 2);
            }

            items[tail++] = item;
        }

        public T Dequeue()
        {
            var item = items[head++];
            items[head - 1] = default(T);

            if (head != tail && ((tail - head) == items.Length / 4))
            {
                Resize(items.Length / 2);
            }

            return item;
        }



    }
}
