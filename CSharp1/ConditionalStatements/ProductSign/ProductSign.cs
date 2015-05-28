//Write a program that shows the sign (+ or -) of the product of three real numbers without calculating it. Use a sequence of if statements.
using System;

class ProductSign
{
    static void Main()
    {
        Console.WriteLine("Enter 3 real numbers:");

        int first = int.Parse(Console.ReadLine());
        int second = int.Parse(Console.ReadLine());
        int third = int.Parse(Console.ReadLine());

        if (first == 0 || second == 0 || third == 0)
        {
            Console.WriteLine("The product is 0");
        }
        else
        {
            bool sign = true;

            if (first < 0)
            {
                sign = !sign;
            }
            if (second < 0)
            {
                sign = !sign;
            }
            if (third < 0)
            {
                sign = !sign;
            }

            if (sign)
            {
                Console.WriteLine("The produt is +");
            }
            else
            {
                Console.WriteLine("The produt sign is -");
            }
        }
    }
}