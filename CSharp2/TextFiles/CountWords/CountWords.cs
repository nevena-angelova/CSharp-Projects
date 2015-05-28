// Write a program that reads a list of words from a file words.txt and finds how many times each of the words is contained
// in another file test.txt. The result should be written in the file result.txt and the words should be sorted by the number
// of their occurrences in descending order. Handle all possible exceptions in your methods.

using System;
using System.Collections.Generic;
using System.IO;

class CountWords
{
    static void Main()
    {
        try
        {
            string wordsFile = @"..\..\words.txt";
            string inputFile = @"..\..\test.txt";
            string outputFile = @"..\..\result.txt";
            StreamWriter writer = new StreamWriter(outputFile);

            // add the contents of the words and the input text to lists

            List<string> words = ReadFile(wordsFile);
            List<string> inputFileContent = ReadFile(inputFile);

            int[] count = new int[words.Count]; // will contains the count of each word.

            // from every item of "inputFileContent" list (which is a line from the input text), creates a splitted array with the words of the line.
            // for every word in the "words" array check wether it contains a word from the given.

            for (int j = 0; j < inputFileContent.Count; j++)
            {
                string[] inputWords = inputFileContent[j].Split(' ');

                for (int k = 0; k < inputWords.Length; k++)
                {
                    for (int i = 0; i < words.Count; i++)
                    {
                        if (inputWords[k].IndexOf(words[i]) != -1)
                        {
                            count[i]++;
                        }
                    }
                }
            }

            // prints the result in the output file

            using (writer)
            {
                for (int i = 0; i < words.Count; i++)
                {
                    writer.WriteLine("{0}, {1} times", words[i], count[i]);
                }
            }

            Console.WriteLine("Done!");
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("Path is null.");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Path is a zero-length string, contains only white space, or contains one or more invalid characters");
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters.");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("The specified path is invalid (for example, it is on an unmapped drive).");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("The file specified in path was not found. ");
        }
        catch (IOException)
        {
            Console.WriteLine("An I/O error occurred while opening the file.");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("path specified a file that is read-only.");
            Console.WriteLine("-or-");
            Console.WriteLine("This operation is not supported on the current platform.");
            Console.WriteLine("-or-");
            Console.WriteLine("path specified a directory.");
            Console.WriteLine("-or-");
            Console.WriteLine("The caller does not have the required permission.");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("Path is in an invalid format.");
        }
        catch (System.Security.SecurityException)
        {
            Console.WriteLine("The caller does not have the required permission.");
        }

    }

    // read from a text file method

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

