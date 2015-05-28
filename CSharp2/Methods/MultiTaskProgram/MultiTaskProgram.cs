// Write a program that can solve these tasks:

// Reverses the digits of a number
// Calculates the average of a sequence of integers
// Solves a linear equation a * x + b = 0

// Create appropriate methods.

// Provide a simple text-based menu for the user to choose which task to solve.

// Validate the input data:
// - The decimal number should be non-negative
// - The sequence should not be empty
// - a should not be equal to 0

using System;

class MultiTaskProgram
{
    static void Main()
    {
        Console.WriteLine("Select a task:");
        Console.WriteLine("Press 1 for \"Reverses the digits of a number\"");
        Console.WriteLine("Press 2 for \"Calculates the average of a sequence of integers\"");
        Console.WriteLine("Press 3 for \"Solves a linear equation a * x + b = 0\"");

        int choise = int.Parse(Console.ReadLine());

        switch (choise)
        {
            case 1: Reverse(); break;
            case 2: CalculateAverage(); break;
            case 3: SolveEquation(); break;
            default: break;
        }
    }

    static void Reverse()
    {
        Console.WriteLine("Enter a number: ");

        int n;

        while (!(int.TryParse(Console.ReadLine(), out n)) || n < 0)
        {
            Console.WriteLine("Enter a valid number!");
        }

        while (n > 0)
        {
            int reminder = n % 10;
            n /= 10;
            Console.Write(reminder);
        }

        Console.WriteLine();
    }

    static void CalculateAverage()
    {
        Console.WriteLine("How many numbers will be in the sequence?");
        int n = int.Parse(Console.ReadLine());

        double[] sequence = new double[n];

        Console.WriteLine("Enter the numbers:");

        for (int i = 0; i < n; i++)
        {
            while (!(double.TryParse(Console.ReadLine(), out sequence[i])))
            {
                Console.WriteLine("Enter a valid number!");
            }
        }

        double sum = 0;

        for (int j = 0; j < n; j++)
        {
            sum += sequence[j];
        }

        double average = sum / n;

        Console.WriteLine(average);
    }

    static void SolveEquation()
    {
        Console.WriteLine("Enter coefficients in a * x + b = 0");
        Console.Write("a = ");

        double a;

        while (!(double.TryParse(Console.ReadLine(), out a)) || a == 0)
        {
            Console.WriteLine("a needs to be greater than 0");
            Console.Write("a = ");
        }

        Console.Write("b = ");

        double b = int.Parse(Console.ReadLine());

        double x = -(b / a);

        Console.WriteLine("x = {0}", x);
    }
}

