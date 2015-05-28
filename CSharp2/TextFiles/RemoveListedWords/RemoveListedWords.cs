// Write a program that removes from a text file all words listed in given another text file. Handle all possible exceptions in your methods.

using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;

class RemoveListedWords
{
    static void Main()
    {
        try
        {
        string inputFile = @"..\..\input.txt";
        StreamReader reader = new StreamReader(inputFile);
        string listFile = @"..\..\list.txt";
        StreamReader listReader = new StreamReader(listFile);
        string outputFile = @"..\..\output.txt";
        StreamWriter writer = new StreamWriter(outputFile);

        List<string> listContent = new List<string>();

        using (listReader)
        {
            string listItem = listReader.ReadLine();

            while (listItem != null)
            {
                listContent.Add(listItem);
                listItem = listReader.ReadLine();
            }
        }

        using (reader)
        using (writer)
        {
            string line = reader.ReadLine();

            string newLine = String.Empty;

            while (line != null)
            {
                for (int i = 0; i < listContent.Count; i++)
                {
                    // removes all words (whole and(*) a part of a word) with no spaces (\s).

                    line = Regex.Replace(line, listContent[i] + @"\s*", string.Empty);
                }

                writer.WriteLine(line);

                line = reader.ReadLine();
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

}

