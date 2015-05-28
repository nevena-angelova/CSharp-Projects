// Write a program that converts a string to a sequence of C# Unicode character literals. Use format strings. 

using System;

class ConvertToUnicodeChar
{
    static void Main()
    {
        Console.WriteLine("Enter a string:");
        string inputStr = Console.ReadLine();

        for (int i = 0; i < inputStr.Length; i++)
        {
            Console.Write("\\u{0:x4}", (ushort)inputStr[i]);
        }

        Console.WriteLine();


    }
}

