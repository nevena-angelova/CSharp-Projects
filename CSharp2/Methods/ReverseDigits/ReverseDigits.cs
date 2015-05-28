// Write a method that reverses the digits of given decimal number. Example: 256  652

using System;

class ReverseDigits
{
    static void Main()
    {
        Console.WriteLine("Enter a number: ");
        int num = int.Parse(Console.ReadLine());

        Reverse(num);
    }

    static void Reverse(int num)
    {
        if (num < 0)
        {
            Console.Write("-");
        }

        num = Math.Abs(num);

        while (num > 0)
        {
            int reminder = num % 10;
            num /= 10;

            Console.Write(reminder);
        }
        Console.WriteLine();
    }
}

