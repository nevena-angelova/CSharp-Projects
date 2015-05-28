// Write a program to calculate the Nth Catalan number by given N.
using System;

class Cards
{
    static void Main()
    {
        string card = null;

        for (int i = 1; i <= 4; i++)
        {
            for (int j = 2; j <= 14; j++)
            {
                switch (j)
                {
                    case 2: card = "2"; break;
                    case 3: card = "3"; break;
                    case 4: card = "4"; break;
                    case 5: card = "5"; break;
                    case 6: card = "6"; break;
                    case 7: card = "7"; break;
                    case 8: card = "8"; break;
                    case 9: card = "9"; break;
                    case 10: card = "10"; break;
                    case 11: card = "J"; break;
                    case 12: card = "D"; break;
                    case 13: card = "K"; break;
                    case 14: card = "A"; break;
                    default: Console.WriteLine("Error"); break;
                }

                switch (i)
                {
                    case 1: card += " of Spades"; break;
                    case 2: card += " of Harts"; break;
                    case 3: card += " of Diamonds"; break;
                    case 4: card += " of Clubs"; break;

                    default: Console.WriteLine("Error"); break;
                }

                Console.WriteLine(card);
            }
        }
    }
}

