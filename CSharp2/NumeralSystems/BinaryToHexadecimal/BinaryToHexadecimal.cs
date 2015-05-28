//Write a program to convert binary numbers to hexadecimal numbers (directly).

using System;

class BinaryToHexadecimal
{
    static void Main()
    {
        Console.WriteLine("Enter a binary number");
        string num = Console.ReadLine();
                
        string hexNum = string.Empty;

        // takes 4 binary digits from the input number, every time stores them in fourBits, compares in the "switch" condition
        // and add the relevent value to hexNum

        for (int i = 0; i <= num.Length-4; i+=4)
        {
            string fourBits = string.Empty;
            fourBits += num[i].ToString() + num[i + 1].ToString() + num[i + 2].ToString() + num[i + 3].ToString();

            switch (fourBits)
            {
                case "0000": hexNum += '0'; break;
                case "0001": hexNum += '1'; break;
                case "0010": hexNum += '2'; break;
                case "0011": hexNum += '3'; break;
                case "0100": hexNum += '4'; break;
                case "0101": hexNum += '5'; break;
                case "0110": hexNum += '6'; break;
                case "0111": hexNum += '7'; break;
                case "1000": hexNum += '8'; break;
                case "1001": hexNum += '9'; break;
                case "1010": hexNum += 'A'; break;
                case "1011": hexNum += 'B'; break;
                case "1100": hexNum += 'C'; break;
                case "1101": hexNum += 'D'; break;
                case "1110": hexNum += 'E'; break;
                case "1111": hexNum += 'F'; break;
                default: break;
            }
        }

        Console.WriteLine(hexNum);
    }
}
