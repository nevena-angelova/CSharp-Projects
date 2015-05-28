// Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.
using System;

class BitExchange
{
    static void Main()
    {
        Console.Write("Enter an integer number: ");
        uint num = uint.Parse(Console.ReadLine());

        // creates shifted by 3 and 24 triple 1 mask (7 = 111)
        uint mask1 = 7 << 3;
        uint mask2 = 7 << 24;

        // extracts the numbers that will be exchanged
        uint extract1 = num & mask1;
        uint extract2 = num & mask2;

        // moves the extracted bits positions by 21 in left and right
        extract1 = extract1 << 21;
        extract2 = extract2 >> 21;

        // makes the bits in num that are for exchange = 0
        uint numZero = num & ~mask1 & ~mask2;

        // sums the shifted extracted numbers with the zeros in the desired places.
        uint result = numZero | extract1 | extract2;

        Console.WriteLine("number  {0,10} (" + Convert.ToString(num, 2).PadLeft(32, '0') + ")", num);
        Console.WriteLine("becomes {0,10} (" + Convert.ToString(result, 2).PadLeft(32, '0') + ")", result);


    }
}

