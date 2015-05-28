//Write a program that creates an array containing all letters from the alphabet (A-Z).
//Read a word from the console and print the index of each of its letters in the array.

using System;

class IndexOfLetters
{
    static void Main()
    {
        char[] letters = new char[52];

        for (int i = 0; i < 26; i++)
        {
            letters[i] = (char)('A' + i);
        }
        for (int j = 26, k = 0; j < 52; j++, k++)
        {
            letters[j] = (char)('a' + k);
        }

        foreach (char item in letters)
        {
            Console.Write(item);
        }

        Console.WriteLine();
        Console.Write("Enter a word: ");
        string word = Console.ReadLine();

        for (int wordLetter = 0; wordLetter < word.Length; wordLetter++)
        {
            for (int letter = 0; letter < 52; letter++)
            {
                if (word[wordLetter] == letters[letter])
                {
                    Console.WriteLine("\"{0}\" is with index {1}", word[wordLetter], letter);
                }
            }
        }


    }
}

