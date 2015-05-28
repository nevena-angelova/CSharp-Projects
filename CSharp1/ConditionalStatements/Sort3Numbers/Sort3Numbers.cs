// Sort 3 real values in descending order using nested if statements.
using System;

class Sort3Numbers
{
    static void Main()
    {
        Console.WriteLine("Enter 3 numbers: ");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        int biggest;
        int middle;
        int smallest;

        if (a == b && a == c)
        {
            Console.WriteLine("The numbers are equal");
        }
        else
        {
            if (a > b && a > c)
            {
                biggest = a;

                if (b > c)
                {
                    middle = b;
                    smallest = c;
                }
                else
                {
                    middle = c;
                    smallest = b;
                }
            }
            else if (b > a && b > c)
            {
                biggest = b;

                if (a > c)
                {
                    middle = a;
                    smallest = c;
                }
                else
                {
                    middle = c;
                    smallest = a;
                }
            }
            else
            {
                biggest = c;

                if (a > b)
                {
                    middle = a;
                    smallest = b;
                }
                else
                {
                    middle = b;
                    smallest = a;
                }
            }

            Console.WriteLine(biggest + ", " + middle + ", " + smallest);
        }
    }
}

