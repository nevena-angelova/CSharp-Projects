namespace Decorator
{
    using System;

    public class WithTopping : Decorator
    {
        public string ToppingType { get; set; }

        public WithTopping(Sweet sweet, string toppingType)
            : base(sweet)
        {
            this.ToppingType = toppingType;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("{0} topping added!", this.ToppingType);
        }
    }
}
