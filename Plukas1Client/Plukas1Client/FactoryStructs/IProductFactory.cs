using Plukas1Client.Products;
using System.Collections.Generic;

namespace Plukas1Client.FactoryStructs
{
    public interface IProductFactory
    {
        ProductABase CreateProductA();
        ProductABase CreateProductA(int number);
        ProductBBase CreateProductB();
    }
}
