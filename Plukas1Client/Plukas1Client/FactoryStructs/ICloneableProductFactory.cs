using Plukas1Client.Products;

namespace Plukas1Client.FactoryStructs
{
    public interface ICloneableProductFactory
    {
        CandyBase CreateProductA(CandyBase prototype);
        MeatBase CreateProductB(MeatBase prototype);
    }
}
