using System;
using System.Collections.Generic;

namespace School
{
    public class Comments
    {
        public string Comment { get; set; }
    }


    public class Discipline : Comments
    {
        private string name;
        private int lectures;
        private int exercises;

        public Discipline(string name, int lectures, int exercises)
        {
            this.name = name;
            this.lectures = lectures;
            this.exercises = exercises;
        }

        // only get - for accsesing the information from the "Print" method

        public string Name { get { return this.name; } }
        public int Lectures { get { return this.lectures; } }
        public int Exercises { get { return this.exercises; } }
    }

    public class People : Comments
    {
        public string Name { get; set; }
    }

    public class Teacher : People
    {
        private List<Discipline> disciplines = new List<Discipline>();

        public Teacher()
        {
        }

        public List<Discipline> Disciplines { get { return this.disciplines; } }

        public void AddDiscipline(Discipline discipline)
        {
            this.disciplines.Add(discipline);
        }

    }

    public class Student : People
    {
        private int identifier;

        public Student(string name, int identifier)
        {
            this.Name = name;
            this.identifier = identifier;
        }

        // only get - for accsesing the information from the "Print" method

        public int Identifier { get { return this.identifier; } }

    }


    public class Class : Comments
    {
        private string identifier;
        private List<Teacher> teachers;
        private List<Student> students;

        public Class(string identifier)
        {
            this.identifier = identifier;
            this.teachers = new List<Teacher>();
            this.students = new List<Student>();
        }

        // only get - for accsesing the information from the "Print" method

        public string Identifier { get { return this.identifier; } }
        public List<Teacher> Teachers { get { return this.teachers; } }
        public List<Student> Students { get { return this.students; } }

        public void AddTeacher(Teacher teacher)
        {
            this.teachers.Add(teacher);
        }

        public void AddStudent(Student student)
        {
            this.students.Add(student);
        }

    }


    public class School
    {
        private string name;
        private List<Class> classes;

        public School(string name)
        {
            this.name = name;
            this.classes = new List<Class>();
        }

        public string Name { get { return this.name; } }

        public void AddClass(Class theClass)
        {
            this.classes.Add(theClass);
        }


        public void Print() // method for printing all the information from the "School" object
        {
            Console.WriteLine("School name: {0}", this.name);
            Console.WriteLine();

            foreach (Class item in classes)
            {
                Console.WriteLine("Class {0}", item.Identifier);

                if (item.Comment != null) // prints the comment if such appears
                {
                    Console.WriteLine("Comment about the class: {0}", item.Comment);
                }

                Console.WriteLine();

                foreach (Student student in item.Students)
                {
                    Console.WriteLine("Student name: {0}", student.Name);
                    Console.WriteLine("Student number: {0}", student.Identifier);

                    if (student.Comment != null)
                    {
                        Console.WriteLine("Comment about the student: {0}", student.Comment);
                    }

                    Console.WriteLine();
                }

                foreach (Teacher teacher in item.Teachers)
                {
                    Console.WriteLine("Teacher's name: {0}", teacher.Name);

                    if (teacher.Comment != null)
                    {
                        Console.WriteLine("Comment about the teacher: {0}", teacher.Comment);
                    }

                    foreach (Discipline discipline in teacher.Disciplines)
                    {
                        Console.WriteLine("Discipline name: {0}", discipline.Name);
                        Console.WriteLine("Discipline lectures: {0}", discipline.Lectures);
                        Console.WriteLine("Discipline exercises: {0}", discipline.Exercises);

                        if (discipline.Comment != null)
                        {
                            Console.WriteLine("Comment about the discipline: {0}", discipline.Comment);
                        }

                    }

                    Console.WriteLine();
                }
            }
        }

    }



    class Program
    {
        static void Main()
        {
            Class firstClass = new Class("A");
            firstClass.Comment = "sreden uspeh 5.25";

            firstClass.AddStudent(new Student("Milena", 21));
            firstClass.AddStudent(new Student("Asen", 2));
            firstClass.AddStudent(new Student("Elena", 6));
            firstClass.Students[0].Comment = "Otsustva do 03.11.2013";

            Teacher teacher1 = new Teacher();
            teacher1.Name = "Stoyanova";
            teacher1.AddDiscipline(new Discipline("Fizika", 12, 5));
            teacher1.Comment = "Shte poeme klasa na Dimitrova do 01.01.2014";

            Teacher teacher2 = new Teacher();
            teacher2.Name = "Grigorov";
            Discipline english = new Discipline("English", 23, 7);
            english.Comment = "Izpolzva se uchebna tetradka";
            teacher2.AddDiscipline(english);
            teacher2.AddDiscipline(new Discipline("French", 17, 3));

            firstClass.AddTeacher(teacher1);
            firstClass.AddTeacher(teacher2);

            School firstSchool = new School("127 SOU");

            firstSchool.AddClass(firstClass);

            firstSchool.Print();

        }
    }
}
