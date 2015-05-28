// Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one. 

using System;
using System.Text;

class RemoveIndenticalLeters
{
    static void Main()
    {
        Console.WriteLine("Enter a word:");

        string inputWord = Console.ReadLine();

        StringBuilder word = new StringBuilder();
        word.Append(inputWord[0]);

        // adds every letter that is not equal to the letter before it to the stringbuilder

        for (int i = 1; i < inputWord.Length; i++)
        {
            if (inputWord[i] != inputWord[i - 1])
            {
                word.Append(inputWord[i]);
            }
        }

        Console.WriteLine(word.ToString());

    }
}

