using Plukas1Client.Products;

namespace Plukas1Client.FactoryStructs
{
    public class DEFamilyFactory : ICloneableProductFactory
    {
        public DEFamilyFactory()
        {

        }

    
        public ProductABase CreateProductA(ProductABase prototype) => (prototype?.Clone() as ProductABase);

        public ProductBBase CreateProductB(ProductBBase prototype) => (prototype?.Clone() as ProductBBase);
    }
}
