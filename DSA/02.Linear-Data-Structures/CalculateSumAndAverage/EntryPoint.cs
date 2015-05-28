//// Write a program that reads from the console a sequence of positive integer numbers.
//// The sequence ends when empty line is entered. Calculate and print the sum and average of
//// the elements of the sequence. Keep the sequence in List<int>.
using System;
using System.Collections.Generic;

public class EntryPoint
{
    public static void Main()
    {
        string inputStr;
        int number;
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter numbers:");

        while (true)
        {
            inputStr = Console.ReadLine();

            if (inputStr == string.Empty)
            {
                break;
            }
            else
            {
                bool isNumber = int.TryParse(inputStr, out number);

                if (!isNumber)
                {
                    throw new ArgumentException("Invalid input data!");
                }
                else
                {
                    numbers.Add(number);
                }
            }
        }

        Console.WriteLine("The sum is: {0}", CalculateSum(numbers));
        Console.WriteLine("The average is: {0}", CalculateAverage(numbers));
    }

    public static int CalculateSum(List<int> numbers)
    {
        int sum = 0;

        for (int i = 0; i < numbers.Count; i++)
        {
            sum += numbers[i];
        }

        return sum;
    }

   public static double CalculateAverage(List<int> numbers)
    {
        return (double)CalculateSum(numbers) / numbers.Count;
    }
}