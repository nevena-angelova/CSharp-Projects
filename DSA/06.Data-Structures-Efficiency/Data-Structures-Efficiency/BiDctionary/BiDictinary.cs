using System;
using System.Linq;
using Wintellect.PowerCollections;

namespace BiDictionaryImplement
{
    public class BiDictionary<K1, K2, V>
    {
        private MultiDictionary<K1, V> firstDictionary;
        private MultiDictionary<K2, V> secondDictionary;
        private MultiDictionary<int, V> thirdDictionary;

        public BiDictionary()
        {
            this.firstDictionary = new MultiDictionary<K1, V>(true);
            this.secondDictionary = new MultiDictionary<K2, V>(true);
            this.thirdDictionary = new MultiDictionary<int, V>(true);
        }

        public void Add(K1 key1, K2 key2, V element)
        {
            this.firstDictionary.Add(key1, element);
            this.secondDictionary.Add(key2, element);
            var hash = this.GetHashFromTwoKeys(key1, key2);
            this.thirdDictionary.Add(hash, element);
        }

        public V[] FindByFirstKey(K1 key)
        {
            return this.firstDictionary[key].ToArray();
        }

        public V[] FindBySecondKey(K2 key)
        {
            return this.secondDictionary[key].ToArray();
        }

        public V[] FindByBothKeys(K1 key1, K2 key2)
        {
            var hash = this.GetHashFromTwoKeys(key1, key2);
            return this.thirdDictionary[hash].ToArray();
        }

        private int GetHashFromTwoKeys(K1 key1, K2 key2)
        {
            return key1.GetHashCode() ^ key2.GetHashCode();
        }
    }
}