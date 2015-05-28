namespace FactoryMethod
{
    using System;

    class Gibson : Manufacturer
    {
        public override Guitar CreateGuitar()
        {
            Guitar guitar = new Guitar("Gibson");
            guitar.Frequency = 2000;
            guitar.Duration = 1600;

            return guitar;
        }

        public override Bass CreateBass()
        {
            Bass bass = new Bass("Gibson");
            bass.Frequency = 400;
            bass.Duration = 1900;

            return bass;
        }
    }
}
