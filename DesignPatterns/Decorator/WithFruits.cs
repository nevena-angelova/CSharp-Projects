namespace Decorator
{
    using System;

    public class WithFruits : Decorator
    {
        public string FruitType { get; set; }

        public WithFruits(Sweet sweet, string fruitType)
            : base(sweet)
        {
            this.FruitType = fruitType;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("{0} fruits added!", this.FruitType);
        }
    }
}
