namespace FactoryMethod
{
    using System;

    public class Bass : StringInstrument
    {
        public Bass(string name)
            : base(name)
        {
        }

        public override void Play()
        {
            Console.WriteLine("{0} bass is playing!", this.Name);
            base.Play();
        }

    }
}
