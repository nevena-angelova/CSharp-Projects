// Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

using System;

class PrintSorted
{
    static void Main()
    {
        Console.WriteLine("Enter words separated by space: ");

        string[] words = Console.ReadLine().Split(' ');

        Array.Sort(words);

        foreach (string word in words)
        {
            Console.Write("{0} ", word);
        }

        Console.WriteLine();
    }
}

