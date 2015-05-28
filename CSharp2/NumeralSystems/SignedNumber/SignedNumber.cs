// Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).

using System;
using System.Collections.Generic;

class SignedNumber
{
    static void Main()
    {
        Console.WriteLine("Enter a signed integer");
        short num = short.Parse(Console.ReadLine());

        short[] numbers = new short[16];

        bool isNegative = false;

        // if the input number is negative, take the absolute value with Math.Abs() and subtract 1

        if (num < 0)
        {
            num = (short)(Math.Abs(num) - 1);
            isNegative = true;
        }

        // convert the input number

        short i = 15;

        while (num > 0)
        {
            short reminder = (short)(num % 2);
            num /= 2;
            numbers[i] = reminder;
            i--;
        }

        // prints the array. If the input number is negative make the array's 0-s to 1 and 1-s to 0;

        for (short j = 0; j < numbers.Length; j++)
        {
            if (isNegative)
            {
                numbers[j] = (short)(numbers[j] ^ 1);
            }
            Console.Write(numbers[j]);
        }

        Console.WriteLine();
    }



}


