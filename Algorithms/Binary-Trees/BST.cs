using System;
using System.Collections;
using System.Collections.Generic;

namespace BinaryTrees
{
    public class BST<TKey, TValue> where TKey : IComparable
    {
        private Node<TKey, TValue> root;

        public TValue Get(TKey key)
        {
            var x = root;

            while (x != null)
            {
                int cmp = key.CompareTo(x.Key);

                if (cmp > 0) // key is bigger
                {
                    x = x.Right;
                }
                else if (cmp < 0)
                {
                    x = x.Left;
                }
                else if (cmp == 0)
                {
                    return x.Value;
                }
            }

            return default;
        }

        public Node<TKey, TValue> GetNode(TKey key)
        {
            var x = root;

            while (x != null)
            {
                int cmp = key.CompareTo(x.Key);

                if (cmp > 0) // key is bigger
                {
                    x = x.Right;
                }
                else if (cmp < 0)
                {
                    x = x.Left;
                }
                else if (cmp == 0)
                {
                    return x;
                }
            }

            return default;
        }


        public Node<TKey, TValue> Min()
        {
            return Min(root);
        }

        private Node<TKey, TValue> Min(Node<TKey, TValue> x)
        {
            if (x == null)
            {
                return null;
            }

            x.Left = Min(x.Left);

            if (x.Left != null)
            {
                return x.Left;
            }
            else
            {
                return x;
            }
        }

        public TKey Floor(TKey key)
        {
            Node<TKey, TValue> x = Floor(root, key);

            if (x == null)
            {
                return default;
            }

            return x.Key;
        }

        // floor 2.4 = 2
        private Node<TKey, TValue> Floor(Node<TKey, TValue> x, TKey key)
        {
            if (x == null)
            {
                return null;
            }

            int cmp = key.CompareTo(x.Key);

            if (cmp < 0) // key is smaller
            {
                return Floor(x.Left, key);
            }

            Node<TKey, TValue> t = Floor(x.Right, key);

            //if there is node equal to the key
            if (t != null)
            {
                return t;
            }
            else
            {
                //entered just one time for the result, just one number bigger
                //the bottom is reached and the value of x is passed as result between all functions in the stack
                return x;
            }
        }

        public int Size()
        {
            return Size(root);
        }

        private int Size(Node<TKey, TValue> x)
        {
            if (x == null)
            {
                return 0;
            }

            return x.Count;
        }


        public void Put(TKey key, TValue value)
        {
            root = Put(root, key, value);
        }

        /// <summary>
        /// Assigns links from one node to another from root to untill reaches null node. 
        /// Then creates a new node which links to the null node and go back to the root.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        private Node<TKey, TValue> Put(Node<TKey, TValue> x, TKey key, TValue value)
        {
            if (x == null)
            {
                return new Node<TKey, TValue>(key, value) { Count = 1 };
            }

            var cmp = key.CompareTo(x.Key);
            if (cmp > 0) // key is bigger
            {
                x.Right = Put(x.Right, key, value);
            }
            else if (cmp < 0)
            {
                x.Left = Put(x.Left, key, value);
            }
            else if (cmp == 0)
            {
                x.Value = value;
            }

            x.Count = 1 + Size(x.Left) + Size(x.Right);

            return x;
        }


        public int Rank(TKey key)
        {
            return Rank(key, root);
        }

        /// <summary>
        /// Rank - number of keys < k
        /// </summary>
        private int Rank(TKey key, Node<TKey, TValue> x)
        {
            if (x == null)
            {
                return 0;
            }

            int cmp = key.CompareTo(x.Key);

            if (cmp < 0) //key is smaller
            {
                return Rank(key, x.Left);
            }
            else if (cmp > 0)
            {
                return 1 + Size(x.Left) + Rank(key, x.Right);
            }
            else // cmp == 0
            {
                return Size(x.Left);
            }
        }


        public IEnumerable<TKey> Keys()
        {
            var q = new Queue<TKey>();

            InOrder(root, q);

            return q;
        }

        private void InOrder(Node<TKey, TValue> x, Queue<TKey> q)
        {
            if (x == null)
            {
                return;
            }

            InOrder(x.Left, q);

            q.Enqueue(x.Key);

            InOrder(x.Right, q);
        }

        public void DeleteMin()
        {
            root = DeleteMin(root);
        }

        private Node<TKey, TValue> DeleteMin(Node<TKey, TValue> x)
        {
            if (x.Left == null)
            {
                return x.Right;
            }

            x.Left = DeleteMin(x.Left);

            x.Count = 1 + Size(x.Left) + Size(x.Right);

            return x;
        }

        public void Delete(TKey key)
        {
            root = Delete(root, key);

        }


        private Node<TKey, TValue> Delete(Node<TKey, TValue> x, TKey key)
        {
            if (x == null)
            {
                return null;
            }

            int cmp = key.CompareTo(x.Key);

            if (cmp < 0) // key is smaller - search for key
            {
                x.Left = Delete(x.Left, key);
            }
            else if (cmp > 0)
            {
                x.Right = Delete(x.Right, key);
            }
            else
            {
                if (x.Right == null)
                {
                    return x.Left; // no right child so replace with child link
                }

                var t = x;
                x = Min(t.Right);
                x.Right = DeleteMin(t.Right);
                x.Left = t.Left;
            }

            x.Count = Size(x.Left) + Size(x.Right) + 1;

            return null;
        }









    }
}
