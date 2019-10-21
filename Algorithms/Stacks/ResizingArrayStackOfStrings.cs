
namespace Stacks
{
    public class ResizingArrayStackOfStrings
    {
        public string[] items;

        public int n;

        public ResizingArrayStackOfStrings()
        {
            this.items = new string[1];
        }

        public bool IsEmpty()
        {
            return n == 0;
        }

        public void Resize(int size)
        {
            var newArr = new string[size];

            for (int i = 0; i < n; i++)
            {
                newArr[i] = items[i];
            }

            items = newArr;
        }

        public void Push(string item)
        {
            if (items.Length == n)
            {
                Resize(n * 2);
            }

            items[n++] = item;
        }


        public string Pop()
        {
            var item = items[--n];

            items[n] = null;

            if (n > 0 && n == (items.Length / 4))
            {
                Resize(items.Length / 2);
            }

            return item;
        }

    }
}
