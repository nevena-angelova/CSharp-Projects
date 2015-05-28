// Write a program that reverses the words in given sentence.

using System;
using System.Text.RegularExpressions;
using System.Text;

class ReverseWords
{
    static void Main()
    {
        Console.WriteLine("Enter a sentence:");
        string sentence = Console.ReadLine();

        string regex = @"\s+|,\s*|\.\s*|!\s*|\?\s*|\;\s*|\:\s*";
        MatchCollection separators = Regex.Matches(sentence, regex);

        string[] words = Regex.Split(sentence, regex);

        // Combine the reversed words with the not reversed separators.
        // the words array lenght is 1 bigger than the separators because of the default white space in the end.
        // So the limit for the loop is the separators lenght.

        for (int j = 0; j < separators.Count; j++)
        {
            Console.Write("{0}{1}", words[words.Length - 2 - j], separators[j]); // words[words.Length - 2 - j] - without the white space in the end
        }

        Console.WriteLine();
    }


}

