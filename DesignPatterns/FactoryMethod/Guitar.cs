namespace FactoryMethod
{
    using System;

    public class Guitar : StringInstrument
    {
        public Guitar(string name)
            : base(name)
        {
        }

        public override void Play()
        {
            Console.WriteLine("{0} guitar is playing!", this.Name);
            base.Play();
        }
    }
}
