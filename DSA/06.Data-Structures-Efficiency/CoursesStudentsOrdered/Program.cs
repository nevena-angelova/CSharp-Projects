/// A text file students.txt holds information about students and their courses in the following format
using System;
using System.Collections.Generic;
using System.IO;

namespace CoursesStudentsOrdered
{
    class Program
    {
        static void Main()
        {
            string studentsFile = @"..\..\students.txt";

            SortedDictionary<string, SortedDictionary<string, string>> students = GroupStudentsByCourse(studentsFile);

            foreach (var student in students)
            {
                Console.Write("{0}: ", student.Key);
                foreach (var pair in student.Value)
                {
                    Console.Write("{0} {1}, ", pair.Key, pair.Value);
                }
                Console.WriteLine();
            }
        }

        static SortedDictionary<string, SortedDictionary<string, string>> GroupStudentsByCourse(string fileName)
        {
            StreamReader reader = new StreamReader(fileName);

            SortedDictionary<string, SortedDictionary<string, string>> students = new SortedDictionary<string, SortedDictionary<string, string>>();
            string[] itemsOnLine;
            string line = reader.ReadLine();
            string course;
            string firstName;
            string lastName;

            using (reader)
            {
                while (line != null)
                {
                    itemsOnLine = line.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                    firstName = itemsOnLine[0].Trim();
                    lastName = itemsOnLine[1].Trim();
                    course = itemsOnLine[2].Trim();

                    if (students.ContainsKey(course))
                    {
                        students[course].Add(firstName, lastName);
                    }
                    else
                    {
                        SortedDictionary<string, string> studentsName = new SortedDictionary<string, string>();
                        studentsName.Add(firstName, lastName);
                        students.Add(course, studentsName);
                    }

                    line = reader.ReadLine();
                }

                return students;
            }
        }
    }
}