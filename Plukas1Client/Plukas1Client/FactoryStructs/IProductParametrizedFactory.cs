using Plukas1Client.Products;

namespace Plukas1Client.FactoryStructs
{
    public interface IProductParametrizedFactory
    {
        ProductABase CreateProductA(params object[] args);
        ProductBBase CreateProductB(params object[] args);
    }
}
