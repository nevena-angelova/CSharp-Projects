//6. Write a program that prints from given array of integers all numbers that are divisible by 7 and 3.
//Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.

using System;
using System.Collections.Generic;
using System.Linq;

namespace PrintDivisibe
{
    class PrintDivisibe
    {
        static void Main()
        {
            List<int> numbersArr = new List<int> { 1, 3, 4, 7, 11, 21, 27, 33, 31, -3, 77, 45, 32, 108, 109, 222, -44 };

            List<int> divisible = numbersArr.FindAll(x => x % 3 == 0 || x % 7 == 0);

            Console.WriteLine();
            Console.WriteLine("Numbers divisible by 3 and 7 found with lambda expression");
            Console.WriteLine();

            foreach (int number in divisible)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine();
            Console.WriteLine("Numbers divisible by 3 and 7 found with LINQ");
            Console.WriteLine();

            var divisibleLINQ =
                from item in numbersArr
                where item % 3 == 0 || item % 7 == 0
                select item;

            foreach (var item in divisibleLINQ)
            {
                Console.WriteLine("{0} ", item);
            }
        }
    }
}
