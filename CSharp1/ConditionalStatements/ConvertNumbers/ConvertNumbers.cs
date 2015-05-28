// * Write a program that converts a number in the range [0...999] to a text corresponding to its English pronunciation. Examples:
//	0  "Zero"
//	273  "Two hundred seventy three"
//	400  "Four hundred"
//	501  "Five hundred and one"
//	711  "Seven hundred and eleven"
using System;

class Convertoness
{
    static void Main()
    {
        Console.WriteLine("Enter a ones in the range [0...999]");
        int inputNum = int.Parse(Console.ReadLine());

        int onesNum = 0;
        int otherNum = 0;
        int tensNum = 0;
        int hundredsNum = 0;

        if (inputNum == 0)
        {
            Console.WriteLine("Zero");
        }
        else if (inputNum > 0 && inputNum < 10)
        {
            onesNum = inputNum;
        }
        else if (inputNum >= 10 && inputNum < 20)
        {
            otherNum = inputNum;
        }
        else if (inputNum >= 20 && inputNum < 100)
        {
            tensNum = inputNum / 10;
            onesNum = inputNum % 10;
        }
        else if (inputNum >= 100 && inputNum < 1000)
        {
            hundredsNum = inputNum / 100;
            tensNum = (inputNum / 10) % 10;
            onesNum = inputNum % 10;

            switch (hundredsNum)
            {
                case 1: Console.Write("one hundred "); break;
                case 2: Console.Write("two hundred "); break;
                case 3: Console.Write("three hundred "); break;
                case 4: Console.Write("four hundred "); break;
                case 5: Console.Write("five hundred "); break;
                case 6: Console.Write("six hundred "); break;
                case 7: Console.Write("seven hundred "); break;
                case 8: Console.Write("eight hundred "); break;
                case 9: Console.Write("nine hundred "); break;
            }

            if (tensNum == 0 && onesNum != 0)
            {
                Console.Write("and ");
            }
            if (tensNum != 0 && onesNum == 0)
            {
                Console.Write("and ");

            }
            if (tensNum == 1)
            {
                Console.Write("and ");
                otherNum = inputNum % 100;
                onesNum = 0;
            }
        }
        else
        {
            Console.WriteLine("The number is not in the range [0...999]");
        }

        switch (otherNum)
        {
            case 10: Console.Write("ten "); break;
            case 11: Console.Write("eleven "); break;
            case 12: Console.Write("twelve "); break;
            case 13: Console.Write("thirteen "); break;
            case 14: Console.Write("fourteen "); break;
            case 15: Console.Write("fifteen "); break;
            case 16: Console.Write("sixteen "); break;
            case 17: Console.Write("seventeen "); break;
            case 18: Console.Write("eighteen "); break;
            case 19: Console.Write("nineteen "); break;
        }

        switch (tensNum)
        {
            case 2: Console.Write("twenty "); break;
            case 3: Console.Write("thirty "); break;
            case 4: Console.Write("fourty "); break;
            case 5: Console.Write("fifty "); break;
            case 6: Console.Write("sixty "); break;
            case 7: Console.Write("seventy "); break;
            case 8: Console.Write("eighty "); break;
            case 9: Console.Write("ninety "); break;
        }

        switch (onesNum)
        {
            case 1: Console.Write("one"); break;
            case 2: Console.Write("two"); break;
            case 3: Console.Write("three"); break;
            case 4: Console.Write("four"); break;
            case 5: Console.Write("five"); break;
            case 6: Console.Write("six"); break;
            case 7: Console.Write("seven"); break;
            case 8: Console.Write("eight"); break;
            case 9: Console.Write("nine"); break;
        }

        Console.WriteLine();
    }
}