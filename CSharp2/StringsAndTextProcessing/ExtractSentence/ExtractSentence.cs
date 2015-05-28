// Write a program that extracts from a given text all sentences containing given word.

using System;
using System.Text.RegularExpressions;

class ExtractSentence
{
    static void Main()
    {
        Console.WriteLine("Enter text:");
        string text = Console.ReadLine();

        Console.WriteLine("Enter a word:");
        string word = Console.ReadLine();

        string[] textArr = text.Split('.');


        for (int i = 0; i < textArr.Length; i++)
        {
            string regexWord = @"\b" + word + @"\b";

            bool match = Regex.IsMatch(textArr[i], regexWord);

            if (match)
            {
                Console.WriteLine("{0}.", textArr[i].Trim());
            }
        }
    }
}

