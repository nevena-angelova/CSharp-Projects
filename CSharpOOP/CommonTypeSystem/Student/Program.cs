using System;

namespace Student
{
    class Program
    {
        static void Main()
        {

            Student student1 = new Student("Zdravko", "Lazarov", "Petrov", "Sofia, Carigradsko shose 11, bl. 191", "+359 887 777 121", "zdr@gmail.com", 287769933, Specialty.Archeology, University.UNI, Faculty.History);
            Student student2 = new Student("Svetlana", "Dimitrova", "Zaharieva", "Sofia, Obelsko shose 23", "+359 230 566", "s_zaharieva@abv.bg", 7824423, Specialty.Microelectroncs, University.TU, Faculty.Electronics);
            Student student3 = new Student("Zdravko", "Lazarov", "Petrov", "Sofia, Hadji Dimitur, bl. 102", "+359 867 216 680", "zdr@gmail.com", 287769933, Specialty.Cinematography, University.NBU, Faculty.Art);

            // test (ex.1)

            //Console.WriteLine(student1.Equals(student3));
            //Console.WriteLine(student1.ToString());

            //Console.WriteLine(student2.GetHashCode());
            //Console.WriteLine(student1.GetHashCode());
            //Console.WriteLine(student3.GetHashCode());

            //Console.WriteLine(student1 == student3);
            //Console.WriteLine(student1 != student3);

            // test (ex. 2)

            //Student student1Copy = student1.Clone();

            //student1Copy.FirstName = "Vyrban";

            //Console.WriteLine(student1.ToString());
            //Console.WriteLine(student1Copy.ToString());

            // test (ex.3)

            int result = student1.CompareTo(student2);

            if (result == 0)
            {
                Console.WriteLine("The students are equal");
            }
            else if (result < 0)
            {
                Console.WriteLine("The first student is earlier than the second");
            }
            else
            {
                Console.WriteLine("The second student is earlier than the first");
            }
        }
    }
}
