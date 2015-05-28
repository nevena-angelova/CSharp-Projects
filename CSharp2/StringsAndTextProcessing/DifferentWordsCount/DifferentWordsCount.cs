// Write a program that reads a string from the console and lists all different words in the string along with information
// how many times each word is found.

using System;
using System.Collections.Generic;

class DifferentWordsCount
{
    static void Main()
    {
        Console.WriteLine("Enter a string:");

        string[] str = Console.ReadLine().Split(new char[] { ' ', '.', ',', '-', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);

        IDictionary<string, int> words = new Dictionary<string, int>();

        // if the current word is in the dictionary increase its key with 1, else adds the word to the dictionary with 
        // key value 1

        foreach (string word in str)
        {
            if (words.ContainsKey(word))
            {
                words[word]++;
            }
            else
            {
                words.Add(word, 1);
            }
        }

        foreach (KeyValuePair<string, int> word in words)
        {
            Console.WriteLine("{0, -15} - {1} times", word.Key, word.Value);
        }
    }
}

