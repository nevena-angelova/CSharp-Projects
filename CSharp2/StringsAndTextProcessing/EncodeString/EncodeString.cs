// Write a program that encodes and decodes a string using given encryption key (cipher). The key consists of a sequence of characters.
// The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string with the first of the key,
// the second – with the second, etc. When the last key character is reached, the next is the first.

using System;
using System.Text;

class EncodeString
{
    static void Main()
    {
        Console.WriteLine("Enter a string:");
        string inputStr = Console.ReadLine();

        Console.WriteLine("Enter key:");
        string key = Console.ReadLine();

        Console.WriteLine(Encode(inputStr, key));
        Console.WriteLine(Encode(Encode(inputStr, key), key)); // Decodes the encoded string
    }

    // take the "i"- th char from the text and XOR it with the [i % key.Length]-th key item.
    // [i % key.Length] - when the last of key chars is reached the next time begins with the first one.

    static string Encode(string str, string key)
    {
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < str.Length; i++)
        {
            result.Append((char)(str[i] ^ key[i % key.Length]));
        }

        return result.ToString();
    }
}
