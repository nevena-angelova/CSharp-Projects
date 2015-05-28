namespace FactoryMethod
{
    using System;

    class Program
    {
        static void Main()
        {
            Fender fender = new Fender();
            Guitar fenderGuitar = fender.CreateGuitar();
            Bass bassFender = fender.CreateBass();

            Gibson gibson = new Gibson();
            Guitar gibsonGuitar = gibson.CreateGuitar();
            Bass gibsonBass = gibson.CreateBass();

            fenderGuitar.Play();
            bassFender.Play();
            gibsonGuitar.Play();
            gibsonBass.Play();
        }
    }
}
