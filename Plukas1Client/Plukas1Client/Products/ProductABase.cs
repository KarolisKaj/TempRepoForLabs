namespace Plukas1Client.Products
{
    using System;
    public class ProductABase : ICloneable
    {
        public ProductABase(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public virtual object Clone()
        {
            return new ProductABase(this.Name);
        }
    }
}
