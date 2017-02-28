using System;
using Plukas1Client.Products;

namespace Plukas1Client.FactoryStructs
{
    class BCFamilyFactory : IProductParametrizedFactory
    {
        public ProductABase CreateProductA(Type t)
        {
           

            return (t.GetConstructor(null).Invoke(null) as ProductABase);
        }

        public ProductBBase CreateProductB(Type t)
        {
            return (t.GetConstructor(null).Invoke(null) as ProductBBase);
        }
    }
}
