// Write a program that finds how many times a substring is contained in a given text (perform case insensitive search).

using System;

class CountSubstringInText
{
    static void Main()
    {
        Console.WriteLine("Enter text:");
        string text = Console.ReadLine().ToLower();

        Console.WriteLine("Enter substring:");
        string substring = Console.ReadLine().ToLower();

        int index = 0;
        int counter = 0;

        for (int i = 0; i < text.Length; i++)
        {
            index = text.IndexOf(substring, i);

            if (index != -1)
            {
                counter++;
                i = index + substring.Length - 1; // the next loop starts from the found index + the searched substring lenght - 1.
            }
        }

        Console.WriteLine("{0} times", counter);
    }
}

