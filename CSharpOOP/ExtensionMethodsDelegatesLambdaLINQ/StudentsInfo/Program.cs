//3. Write a method that from a given array of students finds all students whose first name is before
//its last name alphabetically. Use LINQ query operators.

//4. Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.

//5. Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name and
//last name in descending order. Rewrite the same with LINQ.

//6. Write a program that prints from given array of integers all numbers that are divisible by 7 and 3.
//Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.

using System;
using System.Linq;

namespace StudentsInfo
{
    class Program
    {
        static void Main()
        {

            Student[] students = 
            {
             new Student("Maria", "Stoianova", 17),
             new Student("Maria", "Ivanova", 18),
             new Student("Krasimir", "Jelev", 23),
             new Student("Lazar", "Mihailov", 28),
             new Student("Aleksi", "Todorov", 32),
             new Student("Strahil", "Cvetkov", 18),
             new Student("Ralitza", "Yancheva", 22),            
            };

            // (ex.3)

            Console.WriteLine();
            Console.WriteLine("(ex.3) Students with first name earlyer than last name:");
            Console.WriteLine();

            var respondNameStudents =
                from student in students
                where student.FirstName.CompareTo(student.LastName) == -1
                select student;

            foreach (var student in respondNameStudents)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }

            // (ex.4)

            Console.WriteLine();
            Console.WriteLine("(ex.4) Students with age between 18 and 24 years old:");
            Console.WriteLine();

            var respondYearStudents =
                from student in students
                where student.Age >= 18 && student.Age <= 24
                select student;

            foreach (var student in respondYearStudents)
            {
                Console.WriteLine("{0} {1}; age = {2}", student.FirstName, student.LastName, student.Age);
            }

            //(ex.5)

            Console.WriteLine();
            Console.WriteLine("(ex.5) Students order by name:");
            Console.WriteLine();

            var sortedStudents = students.OrderByDescending(student => student.FirstName).ThenByDescending(student => student.LastName);

            foreach (var student in sortedStudents)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }

            //(ex.6)

            Console.WriteLine();
            Console.WriteLine("(ex.6) Students order by name (LINQ):");
            Console.WriteLine();

            var sortedStudentsLINQ =
                from student in students
                orderby student.FirstName descending, student.LastName descending
                select student;

            foreach (var student in sortedStudentsLINQ)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }

        }
    }
}
