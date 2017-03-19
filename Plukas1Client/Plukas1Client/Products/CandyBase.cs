namespace Plukas1Client.Products
{
    using System;
    public class CandyBase : ICloneable
    {
        public CandyBase(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public virtual object Clone()
        {
            return new CandyBase(this.Name);
        }
    }
}
