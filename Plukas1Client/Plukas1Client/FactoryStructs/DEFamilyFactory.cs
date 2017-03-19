using Plukas1Client.Products;

namespace Plukas1Client.FactoryStructs
{
    public class DEFamilyFactory : ICloneableProductFactory
    {
        public DEFamilyFactory()
        {

        }

    
        public CandyBase CreateProductA(CandyBase prototype) => (prototype?.Clone() as CandyBase);

        public MeatBase CreateProductB(MeatBase prototype) => (prototype?.Clone() as MeatBase);
    }
}
