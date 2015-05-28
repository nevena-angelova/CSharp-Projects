// A dictionary is stored as a sequence of text lines containing words and their explanations.
// Write a program that enters a word and translates it by using the dictionary

using System;

class Dictionary
{
    static void Main()
    {
        string[] dictionary = { ".NET – platform for applications from Microsoft",
                                  "CLR – managed execution environment for .NET",
                                  "namespace – hierarchical organization of classes" };

        Console.WriteLine("Enter a word:");
        string word = Console.ReadLine();

        int index;
        bool notFound = true;

        // search wether the first word in each array item is the wanted word
        // if so prints it and its meaning, which is extracted from the current item from word.Length index.

        for (int i = 0; i < dictionary.Length; i++)
        {
            index = dictionary[i].IndexOf(word, StringComparison.OrdinalIgnoreCase); // case insensitive

            if (index == 0)
            {
                Console.WriteLine("{0}{1}", word, dictionary[i].Substring(word.Length));
                notFound = false;
            }
        }

        if (notFound)
        {
            Console.WriteLine("The word is not found!");
        }

    }

}