namespace BinaryTrees
{
    public class Node<TKey, TValue>
    {
        private TKey key;

        private TValue val;

        private Node<TKey, TValue> left;

        private Node<TKey, TValue> right;

        private int count;

        public Node(TKey key, TValue value)
        {
            this.key = key;
            this.val = value;
        }

        public TKey Key
        {
            get { return key; }

            //set { key = value; }
        }

        public TValue Value
        {
            get { return val; }

            set { val = value; }
        }

        public Node<TKey, TValue> Right
        {
            get { return right; }

            set { right = value; }
        }

        public Node<TKey, TValue> Left
        {
            get { return left; }

            set { left = value; }
        }

        public int Count
        {
            get { return count; }

            set { count = value; }
        }

    }
}
