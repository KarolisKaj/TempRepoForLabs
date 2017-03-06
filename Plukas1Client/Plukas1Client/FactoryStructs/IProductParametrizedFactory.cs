using Plukas1Client.Products;
using System;

namespace Plukas1Client.FactoryStructs
{
    public interface IProductParametrizedFactory: IFactory
    {
        ProductABase CreateProductA(params object[] args);
        ProductBBase CreateProductB(params object[] args);
    }
}
