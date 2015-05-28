//* Write a program that exchanges bits {p, p+1, …, p+k-1) with bits {q, q+1, …, q+k-1} of given 32-bit unsigned integer.
using System;

class BitExchangeExtended
{
    static void Main()
    {
        Console.Write("Enter an integer number: ");
        uint num = uint.Parse(Console.ReadLine());
        Console.Write("Enter number of bits to exchange: ");
        byte k = byte.Parse(Console.ReadLine());
        Console.Write("Enter position of the first right bit: ");
        byte p = byte.Parse(Console.ReadLine());
        Console.Write("Enter position of the first left bit: ");
        byte q = byte.Parse(Console.ReadLine());

        // shifts the bits of n and adds to it "1" k-1 times. For result n has k number of "1"
        uint n = 1;

        for (byte i = 0; i < k - 1; i++)
        {
            n = (n << 1) + 1;
        }

        // creates p and q shifted mask from n.
        uint mask1 = n << p;
        uint mask2 = n << q;

        // extracts the numbers that will be exchanged
        uint extract1 = num & mask1;
        uint extract2 = num & mask2;

        // moves the extracted bits positions by "shift" in left and right
        int shift = q - p;
        extract1 = extract1 << shift;
        extract2 = extract2 >> shift;

        // makes the bits in num that are for exchange = 0
        uint numZero = num & ~mask1 & ~mask2;

        // sums the shifted extracted numbers with the zeros in the desired places.
        uint result = numZero | extract1 | extract2;

        Console.WriteLine("number  {0,10} (" + Convert.ToString(num, 2).PadLeft(32, '0') + ")", num);
        Console.WriteLine("becomes {0,10} (" + Convert.ToString(result, 2).PadLeft(32, '0') + ")", result);
    }
}
