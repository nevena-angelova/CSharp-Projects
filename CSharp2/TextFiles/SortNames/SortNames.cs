// Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file. Example:
// Ivan			    George
// Peter	->		Ivan
// Maria			Maria
// George			Peter

using System;
using System.Collections.Generic;
using System.IO;

class SortNames
{
    static void Main()
    {
        string fileName1 = @"..\..\text1.txt";
        StreamReader reader = new StreamReader(fileName1);

        List<string> FileContent = new List<string>();

        using (reader)
        {
            string list = reader.ReadLine();

            while (list != null)
            {
                FileContent.Add(list);
                list = reader.ReadLine();
            }
        }

        FileContent.Sort();

        string fileName2 = @"..\..\text2.txt";
        StreamWriter writer = new StreamWriter(fileName2);

        using (writer)
        {
            foreach (string item in FileContent)
            {
                writer.WriteLine(item);
            }
        }

        Console.WriteLine("Done!");

    }
}

