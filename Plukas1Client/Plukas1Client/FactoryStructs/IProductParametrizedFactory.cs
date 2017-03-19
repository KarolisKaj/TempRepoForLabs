using Plukas1Client.Products;

namespace Plukas1Client.FactoryStructs
{
    public interface IProductParametrizedFactory
    {
        CandyBase CreateProductA(params object[] args);
        MeatBase CreateProductB(params object[] args);
    }
}
