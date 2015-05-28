// Write a program that reads a string, reverses it and prints the result at the console.

using System;
using System.Text;

class ReverseWord
{
    static void Main()
    {
        Console.WriteLine("Enter a word:");
        string inputWord = Console.ReadLine();

        StringBuilder word = new StringBuilder();

        for (int i = inputWord.Length-1; i >= 0 ; i--)
        {
            word.Append(inputWord[i]);
        }

        Console.WriteLine(word);

    }
}

