namespace Decorator
{
    using System;

    public abstract class Decorator : Sweet
    {
        protected Decorator(Sweet sweet)
        {
            this.Sweet = sweet;
        }

        protected Sweet Sweet { get; set; }

        public override void Display()
        {
            this.Sweet.Display();
        }
    }
}
