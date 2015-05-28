using System;

namespace BiDictionaryImplement
{
    public class Program
    {
        static void Main()
        {
            BiDictionary<int, string, string> students = new BiDictionary<int, string, string>();

            students.Add(5, "C#", "Ani Vasileva");
            students.Add(3, "OOP", "Boris Kirilov");
            students.Add(6, "Java", "Ralitza Goranova");
            students.Add(5, "C#", "Poli Stoyanova");
            students.Add(4, "C#", "Lili Videnova");
            students.Add(4, "Java", "Valeri Peichev");

            string[] studentsByFirstKey = students.FindByFirstKey(3);
            Console.WriteLine("key 3:");
            PrintResult(studentsByFirstKey);

            string[] studentsBySecondKey = students.FindBySecondKey("C#");
            Console.WriteLine("key C#:");
            PrintResult(studentsBySecondKey);

            string[] studentsByBothKeys = students.FindByBothKeys(5, "C#");
            Console.WriteLine("keys 5 and C#:");
            PrintResult(studentsByBothKeys);
        }

        static void PrintResult(string[] students)
        {
            foreach (string student in students)
            {
                Console.WriteLine("{0}, ", student);
            }
        }
    }
}
