// Write a program that deletes from given text file all odd lines. The result should be in the same file.

using System;
using System.IO;
using System.Collections.Generic;

class DeleteOddLines
{
    static void Main()
    {
        string fileName = @"..\..\text.txt";

        StreamReader reader = new StreamReader(fileName);

        List<string> oddLines = new List<string>();

        using (reader)
        {
            string line = reader.ReadLine();
            bool isOdd = false;

            while (line != null) // adds to the list all odd lines
            {
                if (isOdd)
                {
                    oddLines.Add(line);
                    isOdd = false;
                }
                else
                {
                    isOdd = true;
                }

                line = reader.ReadLine();
            }
        }

        StreamWriter writer = new StreamWriter(fileName);

        using (writer)
        {
            for (int i = 0; i < oddLines.Count; i++)
            {
                writer.WriteLine(oddLines[i]);
            }

        }
    }


}


