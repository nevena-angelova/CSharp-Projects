// Create a class Person with two fields – name and age. Age can be left unspecified (may contain null value.
// Override ToString() to display the information of a person and if age is not specified – to say so. Write a program to test this functionality.
using System;

namespace Person
{
    class Program
    {
        static void Main()
        {
            Person person1 = new Person("Velichko");
            Person person2 = new Person("Slavka", 23);

            Console.WriteLine(person1.ToString());
            Console.WriteLine(person2.ToString());
        }
    }
}
