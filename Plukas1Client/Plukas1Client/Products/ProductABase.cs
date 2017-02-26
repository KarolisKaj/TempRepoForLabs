namespace Plukas1Client.Products
{
    using System;
    public abstract class ProductABase : ICloneable
    {
        public ProductABase(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public abstract object Clone();
    }
}
