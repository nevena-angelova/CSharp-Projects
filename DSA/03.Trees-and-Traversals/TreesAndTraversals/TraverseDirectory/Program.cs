/// Write a program to traverse the directory C:\WINDOWS and all its subdirectories recursively and
/// to display all files matching the mask *.exe. Use the class System.IO.Directory.
using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        string rootPath = @"C:\WINDOWS";
        string fileExtension = "*.exe";

        List<string> files = new List<string>();

        TraverseDirectory(rootPath, fileExtension, files);

        foreach (string file in files)
        {
            Console.WriteLine(file);
        }
    }

    public static void TraverseDirectory(string rootPath, string fileExtension, List<string> files)
    {
        try
        {
            string[] currentDirFiles = Directory.GetFiles(rootPath, fileExtension);

            files.AddRange(currentDirFiles);

            string[] curretDirDirectories = Directory.GetDirectories(rootPath);

            foreach (var dir in curretDirDirectories)
            {
                TraverseDirectory(dir, fileExtension, files);
            }
        }
        catch (UnauthorizedAccessException)
        {
        }
    }
}