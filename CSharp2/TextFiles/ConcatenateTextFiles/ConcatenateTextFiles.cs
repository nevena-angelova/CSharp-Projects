// Write a program that concatenates two text files into another text file.

using System;
using System.IO;

class ConcatenateTextFiles
{
    static void Main()
    {
        string fileName1 = @"..\..\text1.txt";
        string fileName2 = @"..\..\text2.txt";
        string fileName3 = @"..\..\text3.txt";

        string fileContent1 = ReadFile(fileName1);
        string fileContent2 = ReadFile(fileName2);

        StreamWriter writer = new StreamWriter(fileName3);

        using (writer)
        {
            writer.WriteLine(fileContent1);
            writer.WriteLine(fileContent2);
        }

        Console.WriteLine("Done!");
    }

    static string ReadFile(string fileName)
    {
        StreamReader reader = new StreamReader(fileName);

        using (reader)
        {
            string fileContent = reader.ReadToEnd();
            return fileContent;
        }
    }

}

