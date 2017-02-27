namespace Plukas1Client.Products
{
    using System;
    using System.Collections.Generic;
    public class ProductBBase : ICloneable
    {
        public ProductBBase(IEnumerable<string> indentifiers)
        {
            Indentifiers = indentifiers;
        }

        public IEnumerable<string> Indentifiers { get; set; }

        public virtual object Clone()
        {
            return new ProductBBase(Indentifiers);
        }
    }
}
