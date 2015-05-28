// Write a program that replaces all occurrences of the substring "start" with the substring "finish" in a text file.
// Ensure it will work with large files (e.g. 100 MB).

using System;
using System.IO;

class ReplaceWords
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
                writer.WriteLine(line.Replace("start", "finish"));
                line = reader.ReadLine();
            }
        }
        Console.WriteLine("Done!");
    }
}

