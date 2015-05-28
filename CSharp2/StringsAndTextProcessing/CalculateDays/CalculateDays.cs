// Write a program that reads two dates in the format: day.month.year and calculates the number of days between them

using System;
using System.Globalization;

class CalculateDays
{
    static void Main()
    {
        Console.Write("Enter first date: ");
        string firstInputDate = Console.ReadLine();
        Console.Write("Enter second date: ");
        string secondInputDate = Console.ReadLine();

        DateTime firstDate = DateTime.ParseExact(firstInputDate, "d.MM.yyyy", CultureInfo.InvariantCulture);
        DateTime secondDate = DateTime.ParseExact(secondInputDate, "d.MM.yyyy", CultureInfo.InvariantCulture);

        TimeSpan result = secondDate - firstDate;
        
        Console.WriteLine(result.Days);

   }
}

