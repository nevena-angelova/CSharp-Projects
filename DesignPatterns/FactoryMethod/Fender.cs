namespace FactoryMethod
{
    using System;

    public class Fender : Manufacturer
    {
        public override Guitar CreateGuitar()
        {
            Guitar guitar = new Guitar("Fender");
            guitar.Frequency = 1700;
            guitar.Duration = 1700;

            return guitar;
        }

        public override Bass CreateBass()
        {
            Bass bass = new Bass("Fender");
            bass.Frequency = 500;
            bass.Duration = 1800;

            return bass;
        }
    }
}
