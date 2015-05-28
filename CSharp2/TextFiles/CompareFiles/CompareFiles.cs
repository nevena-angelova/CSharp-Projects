// Write a program that compares two text files line by line and prints the number of lines that are the same and the number of lines
// that are different. Assume the files have equal number of lines.

using System;
using System.IO;
using System.Collections.Generic;

class CompareFiles
{
    static void Main()
    {
        string fileName1 = @"..\..\text1.txt";
        string fileName2 = @"..\..\text2.txt";

        List<string> fileContent1 = ReadFile(fileName1);
        List<string> fileContent2 = ReadFile(fileName2);

        // compares two lists that contains the two file's content line by line.

        if (fileContent1.Count != fileContent2.Count)
        {
            Console.WriteLine("The two files are with different number of lines!");
        }
        else
        {
            int equal = 0;

            for (int i = 0; i < fileContent1.Count; i++)
            {
                for (int j = 0; j < fileContent2.Count; j++)
                {
                    if (fileContent1[i] == fileContent2[j])
                    {
                        equal++;
                        Console.WriteLine(fileContent1[i]);
                    }
                }
            }

            int notEqual = fileContent1.Count - equal;

            Console.WriteLine();
            Console.WriteLine("Lines that are the same: {0}", equal);
            Console.WriteLine("Lines that are not the same: {0}", notEqual);
        }

    }

    // a read file method that returns a list which contains each line of the document 

    static List<string> ReadFile(string fileName)
    {
        StreamReader reader = new StreamReader(fileName);

        List<string> FileContent = new List<string>();

        using (reader)
        {
            string list = reader.ReadLine();

            while (list != null)
            {
                FileContent.Add(list);
                list = reader.ReadLine();
            }

            return FileContent;

        }
    }
}

