using Plukas1Client.Products;
using System;

namespace Plukas1Client.FactoryStructs
{
    public interface IProductParametrizedFactory
    {
        ProductABase CreateProductA(Type t);
        ProductBBase CreateProductB(Type t);
    }
}
