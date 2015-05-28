/// Implement the data structure "hash table" in a class HashTable<K,T>. Keep the data in array of lists of
/// key-value pairs (LinkedList<KeyValuePair<K,T>>[]) with initial capacity of 16.
/// When the hash table load runs over 75%, perform resizing to 2 times larger capacity.
/// Implement the following methods and properties: Add(key, value), Find(key)value, Remove( key),
/// Count, Clear(), this[], Keys. Try to make the hash table to support iterating over its elements with foreach.
namespace HashTables
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            var table = new HashTable<string, int>();

            table.Add("Zahari", 23);
            table.Add("Silviq", 12);
            table.Add("Boyan", 30);
            table.Add("Svetlia", 20);

            table.Remove("Silviq");

            foreach (var pair in table)
            {
                Console.WriteLine("{0}, {1}", pair.Key, pair.Value);
            }

            Console.WriteLine(table.Find("Boyan").Key);

            Console.WriteLine(table.ContainsKey("Boyan"));
            Console.WriteLine(table.ContainsKey("Ivan"));

        }
    }
}