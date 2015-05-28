// You are given an array of strings. Write a method that sorts the array by the length of its elements
// (the number of characters composing them).

using System;

class SortByLength
{
    static void PrintArray(string[] array)
    {
        foreach (string item in array)
        {
            Console.Write("{0} ", item);
        }
        Console.WriteLine();
    }

    static void Main()
    {
        string[] stringArray = { "bjpf", "sdoso", "dd", "loj", "fof", "jllqjfl", "qfwjpoemmbvmn", "j" };

        PrintArray(stringArray);

        Array.Sort(stringArray, (x, y) => y.Length.CompareTo(x.Length));

        PrintArray(stringArray);
    }
}

