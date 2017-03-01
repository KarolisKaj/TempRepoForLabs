using Plukas1Client.Products;
using System.Collections.Generic;

namespace Plukas1Client.FactoryStructs
{
    public interface IProductFactory
    {
        ProductABase CreateProductA();
        ProductABase CreateProductA(string name);
        ProductABase CreateProductA(string name, string color);
        ProductABase CreateProductA(int number);
        ProductABase CreateProductA(string name, int number);
        ProductBBase CreateProductB();
        ProductBBase CreateProductB(IEnumerable<string> idetifiers);
        ProductBBase CreateProductB(IEnumerable<string> idetifiers, string name);
    }
}
