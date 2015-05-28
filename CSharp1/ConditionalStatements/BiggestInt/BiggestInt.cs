// Write a program that finds the biggest of three integers using nested if statements.
using System;

class BiggestInt
{
    static void Main()
    {
        Console.WriteLine("Enter 3 ineger numbers:");

        int first = int.Parse(Console.ReadLine());
        int second = int.Parse(Console.ReadLine());
        int third = int.Parse(Console.ReadLine());

        if (first >= second && first >= third)
        {
            Console.WriteLine("{0} is biggest!", first);
        }
        else if (second >= first && second >= third)
        {
            Console.WriteLine("{0} is biggest!", second);
        }
        else
        {
            Console.WriteLine("{0} is biggest!", third);
        }
    }
}

