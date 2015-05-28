// Write a program to check if in a given expression the brackets are put correctly.

using System;

class CheckBrackets
{
    static void Main()
    {
        Console.WriteLine("Enter an expression:");

        string expression = Console.ReadLine();

        int counter = 0;

        for (int i = 0; i < expression.Length; i++)
        {
            if (expression[i] == '(')
            {
                counter++;
            }
            else if (expression[i] == ')')
            {
                counter--;
            }

            if (counter < 0)
            {
                break;
            }

        }

        if (counter == 0)
        {
            Console.WriteLine("The brackets are put correctly.");
        }
        else
        {
            Console.WriteLine("The brackets are not put correctly.");
        }

    }
}

