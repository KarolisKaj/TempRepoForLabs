using System.Collections.Generic;

namespace Plukas1Client.Products
{
    public class ProductB1 : ProductBBase
    {
        public ProductB1(IEnumerable<string> indentifiers) : base(indentifiers)
        {
        }
        public ProductB1(IEnumerable<string> indentifiers, string name) : base(indentifiers)
        {
            Name = name;
        }
        public string Name { get; set; }
    }
}
