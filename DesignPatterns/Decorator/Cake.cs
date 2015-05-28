namespace Decorator
{
    using System;

    public class Cake : Sweet
    {
        public Cake(string type)
            : base(type)
        {
        }

        public override void Display()
        {
            Console.WriteLine("{0} cake!", this.Type);
        }
    }
}
