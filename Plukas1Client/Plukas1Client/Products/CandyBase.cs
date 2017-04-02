namespace Plukas1Client.Products
{
    using System;
    public abstract class CandyBase : ICloneable
    {
        public CandyBase(string name)
        {
            Name = name;
        }

        protected CandyBase(CandyBase from)
        {
            Name = from.Name;
        }

        public string Name { get; }

        public abstract bool Eat(int time);
        public abstract object Clone();
    }
}
