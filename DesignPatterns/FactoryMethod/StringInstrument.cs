namespace FactoryMethod
{
    using System;

    public abstract class StringInstrument
    {
        public StringInstrument(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public int NumberOfStrings { get; set; }

        public int NumberOfAdapters { get; set; }

        public string Color { get; set; }

        public int Frequency { get; set; }

        public int Duration { get; set; }

        public virtual void Play()
        {
            Console.Beep(this.Frequency, this.Duration);
        }

    }
}
