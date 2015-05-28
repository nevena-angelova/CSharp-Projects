// Write a program that reads a text file and inserts line numbers in front of each of its lines.
// The result should be written to another text file.

using System;
using System.Text;
using System.IO;

class InsertLineNumbers
{
    static void Main()
    {
        string fileName1 = @"..\..\text1.txt";
        StreamReader reader = new StreamReader(fileName1);

        StringBuilder fileContent = new StringBuilder();

        using (reader)
        {
            string line = reader.ReadLine();
            int lineNumber = 1;

            while (line != null)
            {
                fileContent.Append(lineNumber);
                fileContent.Append(".");
                fileContent.Append(line);
                fileContent.Append("\r\n");

                lineNumber++;
                line = reader.ReadLine();
            }
        }

        string fileName2 = @"..\..\text2.txt";
        StreamWriter writer = new StreamWriter(fileName2);

        using (writer)
        {
            writer.Write(fileContent.ToString());
        }
        Console.WriteLine("Done!");
    }
}

