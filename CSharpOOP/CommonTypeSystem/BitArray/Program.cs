using System;

namespace BitArray
{
    class Program
    {
        static void Main()
        {
            BitArray firstBitArray = new BitArray(255);

            Console.WriteLine(firstBitArray[1]);

            foreach (int item in firstBitArray)
            {
                Console.Write(item);
            }

            Console.WriteLine();

            BitArray secondBitArray = new BitArray(255);

            Console.WriteLine(firstBitArray.Equals(secondBitArray));
            Console.WriteLine(firstBitArray == secondBitArray);
            Console.WriteLine(firstBitArray != secondBitArray);

            Console.WriteLine(firstBitArray.GetHashCode());
        }

    }
}
