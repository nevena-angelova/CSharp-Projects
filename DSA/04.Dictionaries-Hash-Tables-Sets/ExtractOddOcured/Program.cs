/// Write a program that extracts from a given sequence of strings all elements that present in it odd number of times. 
namespace ExtractOddOcured
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            string[] words = new string[] { "C#", "SQL", "PHP", "PHP", "SQL", "SQL" };

            Dictionary<string, int> wordsCount = new Dictionary<string, int>();

            for (int i = 0; i < words.Length; i++)
            {
                if (wordsCount.ContainsKey(words[i]))
                {
                    wordsCount[words[i]]++;
                }
                else
                {
                    wordsCount.Add(words[i], 1);
                }
            }

            foreach (var pair in wordsCount)
            {
                if (pair.Value % 2 != 0)
                {
                    Console.WriteLine(pair.Key);
                }
            }
        }
    }
}