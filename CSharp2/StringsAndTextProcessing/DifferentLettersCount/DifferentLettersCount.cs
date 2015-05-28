// Write a program that reads a string from the console and prints all different letters in the string along with
// information how many times each letter is found. 

using System;

class DifferentLettersCount
{
    static void Main()
    {
        Console.WriteLine("Enter a string:");

        string str = Console.ReadLine();

        char[] letterCount = new char[65536];

        // increases the letterCount array items with index equal to the letter's unicode with 1

        for (int i = 0; i < str.Length; i++)
        {
            letterCount[(int)str[i]]++;
        }

        // prints all letterCount items that are not equal to 0.

        for (int j = 0; j < letterCount.Length; j++)
        {
            if (letterCount[j] != 0)
            {
                Console.WriteLine("{0} - {1} times", (char)j, (int)letterCount[j]);
            }
        }
    }
}

