using System;

namespace Shuffling
{
    class Program
    {
        static void Main()
        {
            var cards = new int[9] { 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var rndGenerator = new Random();

            for (int i = 0; i < cards.Length; i++)
            {
                var num = rndGenerator.Next(0, i);

                var temp = cards[i];
                cards[i] = cards[num];
                cards[num] = temp;
            }

            Console.WriteLine(string.Join(",", cards));
        }
    }
}
