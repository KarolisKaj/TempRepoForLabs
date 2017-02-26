namespace Plukas1Client.Products
{
    using System;
    using System.Collections.Generic;
    public abstract class ProductBBase : ICloneable
    {
        public ProductBBase(IEnumerable<string> indentifiers)
        {
            Indentifiers = indentifiers;
        }

        public IEnumerable<string> Indentifiers { get; set; }

        public abstract object Clone();
    }
}
