namespace Decorator
{
    using System;

    public abstract class Sweet
    {
        public Sweet(string type = null)
        {
            this.Type = type;
        }

        public string Type { get; set; }

        public abstract void Display();
    }
}
