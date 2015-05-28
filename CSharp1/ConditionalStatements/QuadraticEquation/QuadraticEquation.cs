// Write a program that enters the coefficients a, b and c of a quadratic equation
// a*x2 + b*x + c = 0
// and calculates and prints its real roots. Note that quadratic equations may have 0, 1 or 2 real roots.
using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.WriteLine("Enter coefficients for a, b and c in ax2+bx+c=0: ");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double x1;
        double x2;

        double D = b * b - 4 * a * c;

        if (D < 0 && a != 0)
        {
            Console.WriteLine("The equation has no real roots");
        }
        else if (D >= 0 && a != 0)
        {
            x1 = (-b + Math.Sqrt(D)) / (2 * a);
            x2 = (-b - Math.Sqrt(D)) / (2 * a);

            if (x1 == x2)
            {
                x1 = x2 = -b / (2 * a);
                Console.WriteLine("The equation has one real root x: {0}", x1);
            }
            else
            {
                Console.WriteLine("The equation has two real roots: x1 = {0}; x2 = {1}", x1, x2);
            }
        }
        else
        {
            Console.WriteLine("\"a\" needs to be different from 0");
        }
    }
}