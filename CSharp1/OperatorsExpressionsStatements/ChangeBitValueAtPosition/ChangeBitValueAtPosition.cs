// We are given integer number n, value v (v=0 or 1) and a position p. Write a sequence of operators that modifies n to
// hold the value v at the position p from the binary representation of n.
// Example: n = 5 (00000101), p=3, v=1  13 (00001101)
// n = 5 (00000101), p=2, v=0  1 (00000001)

using System;

class ChangeBitValueAtPosition
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        Console.Write("Enter a position: (0-31) ");
        int p = int.Parse(Console.ReadLine());
        Console.Write("Enter a value (0 or 1): ");
        int v = int.Parse(Console.ReadLine());

        int result = v == 1 ? num | 1 << p : num & ~(1 << p);

        Console.WriteLine("In {0} (" + Convert.ToString(num, 2).PadLeft(32, '0') + "), position {1}, to set the value {2}.", num, p, v);
        Console.WriteLine("The changed number is {0} (" + Convert.ToString(result, 2).PadLeft(32, '0') + ")", result);


    }
}
