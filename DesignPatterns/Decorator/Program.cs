namespace Decorator
{
    using System;

    class Program
    {
        static void Main()
        {
            Cake cake = new Cake("sour cream");
            WithFruits cakeWithFriuts = new WithFruits(cake, "strawberries");
            WithTopping cakeWithFriutsAndTopping = new WithTopping(cakeWithFriuts, "chocolate");

            cakeWithFriutsAndTopping.Display();

            Console.WriteLine();

            IceCream iceCream = new IceCream("chocolate");
            WithTopping iceCreamWithTopping = new WithTopping(iceCream, "chopped nuts");
            WithFruits iceCreamWithToppingAndFruits = new WithFruits(iceCreamWithTopping, "figs");

            iceCreamWithToppingAndFruits.Display();
        }
    }
}
