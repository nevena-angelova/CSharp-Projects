namespace Decorator
{
    using System;

    public class IceCream : Sweet
    {
        public IceCream(string type)
            : base(type)
        {
        }

        public override void Display()
        {
            Console.WriteLine("{0} ice cream!", this.Type);
        }

    }
}
