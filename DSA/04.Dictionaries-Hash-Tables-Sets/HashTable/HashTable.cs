namespace HashTables
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class HashTable<K, V> : IEnumerable<KeyValuePair<K, V>>
    {
        const int InitialValuesSize = 16;
        private LinkedList<KeyValuePair<K, V>>[] values;

        public HashTable()
        {
            this.values = new LinkedList<KeyValuePair<K, V>>[InitialValuesSize];
        }

        public int Count { get; private set; }

        public int Capacity
        {
            get { return this.values.Length; }
        }

        public KeyValuePair<K, V> this[K key, V val]
        {
            get
            {
                return this.Find(key);
            }
            set
            {
                this.Add(key, val);
            }
        }

        public void Add(K key, V value)
        {
            var hash = GetHashKey(key);

            if (this.values[hash] == null)
            {
                this.values[hash] = new LinkedList<KeyValuePair<K, V>>();
            }

            bool alreadyHasKey = this.values[hash].Any(v => v.Key.Equals(key));

            if (alreadyHasKey)
            {
                throw new ArgumentException("Key already exists!");
            }

            KeyValuePair<K, V> pair = new KeyValuePair<K, V>(key, value);

            this.values[hash].AddLast(pair);
            this.Count++;

            if (this.Count >= 0.75 * this.Capacity)
            {
                this.ResizeAndReadValues();
            }
        }

        public void Remove(K key)
        {
            var hash = this.GetHashKey(key);
            KeyValuePair<K, V> pairToRemove = this.Find(key);
            values[hash].Remove(pairToRemove);
        }

        public KeyValuePair<K, V> Find(K key)
        {
            var hash = this.GetHashKey(key);

            if (this.values[hash] != null)
            {
                return this.values[hash].First(v => v.Key.Equals(key));
            }

            throw new ArgumentException("Nothing found!");
        }

        public bool ContainsKey(K key)
        {
            var hash = GetHashKey(key);

            if (this.values[hash] == null)
            {
                return false;
            }

            var pairs = this.values[hash];
            return pairs.Any(p => p.Key.Equals(key));
        }

        private int GetHashKey(K key)
        {
            var hash = key.GetHashCode();
            hash %= this.Capacity;
            hash = Math.Abs(hash);
            return hash;
        }

        private void ResizeAndReadValues()
        {
            var cachedValues = this.values;

            this.values = new LinkedList<KeyValuePair<K, V>>[2 * this.Capacity];

            this.Count = 0;

            foreach (var valueCollection in cachedValues)
            {
                if (valueCollection != null)
                {
                    foreach (var value in valueCollection)
                    {
                        this.Add(value.Key, value.Value);
                    }
                }
            }
        }

        public void Clear()
        {
            this.values = new LinkedList<KeyValuePair<K, V>>[InitialValuesSize];
            this.Count = 0;
        }

        public IEnumerator<KeyValuePair<K, V>> GetEnumerator()
        {
            foreach (var valueCollection in this.values)
            {
                if (valueCollection != null)
                {
                    foreach (var value in valueCollection)
                    {
                        yield return value;
                    }
                }
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}