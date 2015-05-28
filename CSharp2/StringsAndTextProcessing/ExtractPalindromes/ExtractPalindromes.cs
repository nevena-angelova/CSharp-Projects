// Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".

using System;

class ExtractPalindromes
{
    static void Main()
    {
        string text = "ABBA, music, lamal, exe, file, tiger, neven, exercises";

        string[] words = text.Split(' ', ',');

        int counter;

        // checks wether the first letter in each word is equal to the last one,
        // then compares the second and the one before the last one an so on...
        // if true the counter++, if the counter becomes equal to the word lenght/2 then the word is palindrome.

        for (int i = 0; i < words.Length; i++)
        {
            counter = 0;

            for (int j = 0; j < words[i].Length; j++)
            {
                if (words[i][j] == words[i][words[i].Length - 1 - j])
                {
                    counter++;

                    if (counter == words[i].Length / 2)
                    {
                        Console.WriteLine(words[i]);
                    }
                }
            }
        }
    }
}

