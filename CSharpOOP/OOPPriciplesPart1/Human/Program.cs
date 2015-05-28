using System;
using System.Collections.Generic;
using System.Linq;

namespace Human
{

    public abstract class Human
    {
        private string firstName, lastName;

        public string FirstName
        {
            get { return this.firstName; }
        }

        public string LastName
        {
            get { return this.lastName; }
        }

        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
    }

    public class Student : Human
    {
        private int grade;

        public int Grade
        {
            get { return this.grade; }
        }

        public Student(string firstName, string lastName, int grade)
            : base(firstName, lastName)
        {
            this.grade = grade;
        }

    }

    public class Worker : Human
    {

        private int weekSalary;
        private int workHoursPerDay;

        public Worker(string firstName, string lastName, int weekSalary, int workHoursPerDay)
            : base(firstName, lastName)
        {
            this.weekSalary = weekSalary;
            this.workHoursPerDay = workHoursPerDay;
        }

        public double MoneyPerHour()
        {
            return (double)this.weekSalary / (5 * this.workHoursPerDay);
        }
    }


    class Program
    {
        static void Main()
        {
            List<Student> students = new List<Student> 
            { 
            new Student("Ivailo", "Hristov", 1),
            new Student("Stefka", "Subeva", 3),
            new Student("Radostina", "Koicheva", 5),
            new Student("Dobromira", "Jeliazkova", 2),
            new Student("Valeri", "Harizanov", 4),
            new Student("Perla", "Koicheva", 1),
            new Student("Dobri", "Gospodinov", 2),
            new Student("Krasimir", "Borisov", 6),
            new Student("Marinela", "Peicheva", 3)
            };

            var sortedStudents = students.OrderBy(student => student.Grade);

            Console.WriteLine("Students order by grade:");
            Console.WriteLine();

            foreach (Student item in sortedStudents)
            {
                Console.WriteLine("{0} {1}, grade: {2}", item.FirstName, item.LastName, item.Grade);
            }


            List<Worker> workers = new List<Worker>
            {
                new Worker("Ivailo", "Peshev", 280, 8),
                new Worker("Slavcho", "Hristov", 500, 9),
                new Worker("Emanuela", "Dikova", 300, 8),
                new Worker("Boris", "Karamfilov", 100, 4),
                new Worker("Kaloian", "Shishkov", 400, 8),
                new Worker("Boika", "Petrova", 450, 8),
                new Worker("Dragoi", "Kunchev", 700, 9),
                new Worker("Bistra", "Mechkova", 320, 5),
                new Worker("Tisho", "Lisichkov", 350, 8),
                new Worker("Darina", "Tiutiundjieva", 200, 6)
            };

            Console.WriteLine();
            Console.WriteLine("Workers sorted by money per hour:");
            Console.WriteLine();

            var sortedWorkers = workers.OrderByDescending(worker => worker.MoneyPerHour());

            foreach (Worker item in sortedWorkers)
            {
                Console.WriteLine("{0} {1}, money per hour: {2}", item.FirstName, item.LastName, item.MoneyPerHour());
            }

            List<Human> humans = new List<Human>();
            humans.AddRange(students);
            humans.AddRange(workers);

            var sortedHumans = humans.OrderBy(human => human.FirstName).ThenBy(human => human.LastName);

            Console.WriteLine();
            Console.WriteLine("All humans sorted:");
            Console.WriteLine();

            foreach (Human item in sortedHumans)
            {
                Console.WriteLine("{0} {1}", item.FirstName, item.LastName);
            }

        }
    }
}
