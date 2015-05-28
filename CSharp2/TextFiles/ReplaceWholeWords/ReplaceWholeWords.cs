// Modify the solution of the previous problem to replace only whole words (not substrings).

using System;
using System.IO;
using System.Text.RegularExpressions;


    class ReplaceWholeWords
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
                    writer.WriteLine(Regex.Replace(line, @"\bstart\b", "finish")); // using regular expressions
                    line = reader.ReadLine();
                }
            }
            Console.WriteLine("Done!");
        }
    }

