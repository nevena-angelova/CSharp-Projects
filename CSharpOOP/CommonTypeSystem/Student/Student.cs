using System;
using System.Text;

namespace Student
{

    public enum Specialty
    {
        Мathematics, Physics, NuclearPhysics, Chemistry, Informatics, Biology, Medicine, Microbiology,
        Electronics, Microelectroncs, Мechanics, Automatic, ComputerTehnology,
        Russian, English, History, Archeology,
        InternationalRelations, Statistics, Religion, SocialActivity,
        GrahicDesign, Cinematography
    }

    public enum University
    {
        TU, UNI, UNWE, MU, NBU
    }

    public enum Faculty
    {
        Electronics, МechanicsAndAutomatic, ComputerTehnology, MathematicsAndInformatics,
        Physics, Chemistry, Biology, History, Languages, Humanities, Iconomics, Art
    }

    class Student : ICloneable, IComparable<Student>
    {
        private string firstName, middleName, lastName, arddress, phone, email;
        private int ssn;
        private Specialty speciality;
        private University university;
        private Faculty faculty;

        public Student(string firstName, string middleName, string lastName, string arddress,
            string phone, string email, int ssn, Specialty speciality, University university, Faculty faculty)
        {
            this.firstName = firstName;
            this.middleName = middleName;
            this.lastName = lastName;
            this.arddress = arddress;
            this.phone = phone;
            this.email = email;
            this.ssn = ssn;
            this.speciality = speciality;
            this.university = university;
            this.faculty = faculty;
        }

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        public override bool Equals(object obj)
        {
            Student student = obj as Student;

            if (!this.firstName.Equals(student.firstName))
            {
                return false;
            }
            if (!this.middleName.Equals(student.middleName))
            {
                return false;
            }
            if (!this.lastName.Equals(student.lastName))
            {
                return false;
            }

            return true;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append("First name: " + this.firstName);
            result.Append("\nMiddle name: " + this.middleName);
            result.Append("\nLast name: " + this.lastName);
            result.Append("\nFaculty: " + this.faculty);
            result.Append("\nSpeciality: " + this.speciality);
            result.Append("\nUniversity: " + this.university);

            return result.ToString();
        }

        public override int GetHashCode()
        {
            return this.firstName.GetHashCode() ^ this.middleName.GetHashCode() ^ this.lastName.GetHashCode();
        }

        public static bool operator ==(Student st1, Student st2)
        {
            return st1.Equals(st2);
        }

        public static bool operator !=(Student st1, Student st2)
        {
            return !st1.Equals(st2);
        }

        object ICloneable.Clone()
        {
            return this.Clone();
        }

        public Student Clone()
        {
            Student newStudent = new Student(this.firstName, this.middleName, this.lastName, this.arddress,
            this.phone, this.email, this.ssn, this.speciality, this.university, this.faculty);
            return newStudent;
        }

        public int CompareTo(Student student)
        {
            if (!this.firstName.Equals(student.firstName))
            {
                return this.firstName.CompareTo(student.firstName);
            }
            if (!this.middleName.Equals(student.middleName))
            {
                return this.middleName.CompareTo(student.middleName);
            }
            if (!this.lastName.Equals(student.lastName))
            {
                return this.lastName.CompareTo(student.lastName);
            }
            if (this.ssn != student.ssn)
            {
                return this.ssn.CompareTo(student.ssn);
            }

            return 0;
        }
    }
}
