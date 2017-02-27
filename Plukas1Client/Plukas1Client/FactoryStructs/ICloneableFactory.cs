using Plukas1Client.Products;

namespace Plukas1Client.FactoryStructs
{
    public interface ICloneableFactory
    {
     
            ProductABase CreateProductA(ProductABase prototype);
            ProductBBase CreateProductB(ProductBBase prototype);
    }
}
