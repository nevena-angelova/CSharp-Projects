// Write an if statement that examines two integer variables and exchanges their values if the first one is greater than the second one.
using System;

class ExchangeValues
{
    static void Main()
    {
        Console.Write("Enter the first integer number: ");
        int first = int.Parse(Console.ReadLine());
        Console.Write("Enter the second integer number: ");
        int second = int.Parse(Console.ReadLine());

        if (first > second)
        {
            first = first - second;
            second = second + first;
            first = second - first;

            Console.WriteLine("The first number is bigger than the second so their values are exchanged.\nThe first number is {0} and the second {1}", first, second);
        }
        else
        {
            Console.WriteLine("The second number is bigger than the first.");
        }


    }
}