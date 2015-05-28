// We are given a string containing a list of forbidden words and a text containing some of these words.
// Write a program that replaces the forbidden words with asterisks.

using System;

class ReplaceForbiddenWords
{
    static void Main()
    {
        Console.WriteLine("Enter forbidden word separated by comma:");
        string[] words = Console.ReadLine().Split(',');

        Console.WriteLine("Enter a text:");
        string text = Console.ReadLine();

        int index;
        string asterisk;
        int length;

        for (int i = 0; i < words.Length; i++)
        {
            for (int j = 0; j < text.Length; j++)
            {
                index = text.IndexOf(words[i]);

                if (index != -1)
                {
                    length = words[i].Length;
                    asterisk = new string('*', length);
                    text = text.Replace(words[i], asterisk);

                    j += index + length;
                }
            }
        }

        Console.WriteLine(text);

    }
}

