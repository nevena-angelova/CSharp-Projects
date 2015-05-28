// Write a program that deletes from a text file all words that start with the prefix "test". Words contain only the symbols 0...9, a...z, A…Z, _.

using System;
using System.IO;
using System.Text.RegularExpressions;

class RemoveWords
{
    static void Main()
    {
        string inputFile = @"..\..\input.txt";
        StreamReader reader = new StreamReader(inputFile);
        string outputFile = @"..\..\output.txt";
        StreamWriter writer = new StreamWriter(outputFile);

        
            using (reader)
            using (writer)
            {
                string line = reader.ReadLine();

                while (line != null)
                {
                    writer.WriteLine(Regex.Replace(line, @"\b(test\w*(\s|\S))\b", string.Empty)); // using regular expressions
                    line = reader.ReadLine();
                }
            }
            Console.WriteLine("Done!");
    }
}

