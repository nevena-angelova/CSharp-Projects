// Write a program that reads a text file and prints on the console its odd lines.

using System;
using System.IO;

class PrintOddLines
{
    static void Main()
    {
        string fileName = @"..\..\text.txt";

        StreamReader reader = new StreamReader(fileName);

        using (reader)
        {
            string line = reader.ReadLine();
            int lineNum = 1;

            while (line != null)
            {
                if (lineNum % 2 != 0)
                {
                    Console.WriteLine(line);
                }

                lineNum++;
                line = reader.ReadLine();
            }
        }
    }
}
