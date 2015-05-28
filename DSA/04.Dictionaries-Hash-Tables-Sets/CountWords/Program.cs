/// Write a program that counts how many times each word from given text file words.txt appears in it.
/// The character casing differences should be ignored. The result words should be ordered by their
/// number of occurrences in the text.
namespace CountWords
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            string wordsFile = @"..\..\words.txt";

            Dictionary<string, int> words = CountWords(wordsFile);

            foreach (var wordPair in words.OrderBy(w => w.Value))
            {
                Console.WriteLine("{0} -> {1}", wordPair.Key, wordPair.Value);
            }

        }

        static Dictionary<string, int> CountWords(string fileName)
        {
            StreamReader reader = new StreamReader(fileName);

            Dictionary<string, int> words = new Dictionary<string, int>();

            using (reader)
            {
                string line = reader.ReadLine();
                char[] splitOptions = new char[] { ' ', ',', '.', '?', '!', ':', ';', '-', '\t' };
                string word;

                while (line != null)
                {
                    string[] wordsOnLine = line.Split(splitOptions, StringSplitOptions.RemoveEmptyEntries);

                    for (int i = 0; i < wordsOnLine.Length; i++)
                    {
                        word = wordsOnLine[i].ToLower();

                        if (words.ContainsKey(word))
                        {
                            words[word]++;
                        }
                        else
                        {
                            words.Add(word, 1);
                        }
                    }

                    line = reader.ReadLine();
                }

                return words;
            }
        }
    }
}