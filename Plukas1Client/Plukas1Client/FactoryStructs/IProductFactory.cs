using Plukas1Client.Products;
using System.Collections.Generic;

namespace Plukas1Client.FactoryStructs
{
    public interface IProductFactory
    {
        ProductABase CreateProductA(string name, int number);
        ProductBBase CreateProductB(IEnumerable<string> idetifiers, string name);
    }
}
