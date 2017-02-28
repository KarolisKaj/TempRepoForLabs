namespace Plukas1Client.Products
{
    using System;
    using System.Collections.Generic;
    public class ProductBBase
    {
        public ProductBBase(IEnumerable<string> indentifiers)
        {
            Indentifiers = indentifiers;
        }

        public IEnumerable<string> Indentifiers { get; set; }

        public virtual ProductBBase Clone()
        {
            return this.Copy();
        }
    }
}
