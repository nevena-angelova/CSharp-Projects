//Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.

using System;

class BitPosition3rd
{
    static void Main()
    {
        Console.Write("Enter a Number: ");
        int num = int.Parse(Console.ReadLine());
        byte mask = 1 << 3;

        int result = num & mask;

        string isOneOrZero = result >> 3 == 1 ? "1" : "0";

        Console.WriteLine("The 3-rd bit of {0} (" + Convert.ToString(num, 2).PadLeft(16, '0') + ") is {1}", num, isOneOrZero);
    }
}

