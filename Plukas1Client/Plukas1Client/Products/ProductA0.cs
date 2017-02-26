namespace Plukas1Client.Products
{
    using System;
    public class ProductA0 : ProductABase
    {
        public ProductA0(string name) : base(name)
        {
        }

        public override object Clone()
        {
            throw new NotImplementedException();
        }
    }
}
