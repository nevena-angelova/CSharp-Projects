namespace FactoryMethod
{
    using System;

    public abstract class Manufacturer
    {
        public abstract Guitar CreateGuitar();

        public abstract Bass CreateBass();
    }
}
