// Write a program that, depending on the user's choice inputs int, double or string variable.
// If the variable is integer or double, increases it with 1. If the variable is string, appends "*" at its end.
// The program must show the value of that variable as a console output. Use switch statement.
using System;

class IntDoubleString
{
    static void Main()
    {
        Console.WriteLine("Enter \"1\" for int, \"2\" for double and \"3\" for string:");
        int choise = int.Parse(Console.ReadLine());

        switch (choise)
        {
            case 1: Console.WriteLine("Enter an integer:");
                int intNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("The result of adding 1 is: {0}", intNumber + 1);
                break;
            case 2: Console.WriteLine("Enter a double number:");
                double doubleNumber = double.Parse(Console.ReadLine());
                Console.WriteLine("The result of adding 1 is: {0}", doubleNumber + 1);
                break;
            case 3: Console.WriteLine("Enter a string:");
                string strEntered = Console.ReadLine();
                Console.WriteLine("The result of adding * is: {0}", strEntered + "*");
                break;
        }
    }
}
