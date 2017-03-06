namespace Plukas1Client.Products
{
    using System.Collections.Generic;
    public class ProductB0 : ProductBBase
    {
        public ProductB0(IEnumerable<string> indentifiers) : base(indentifiers)
        {
        }

        public ProductB0(IEnumerable<string> indentifiers, int count) : this(indentifiers)
        {
            Count = count;
        }
        public int Count { get; set; }
    }
}

