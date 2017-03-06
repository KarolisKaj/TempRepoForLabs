namespace Plukas1Client.FactoryStructs
{
    using System.Collections.Generic;
    using Products;

    public class AFamilyFactory : IProductFactory
    {
        public AFamilyFactory()
        {
        }

        public ProductABase CreateProductA(string name = "DefaultName", int number = 15)
        {
            return new ProductA0(name, number);
        }

        public ProductBBase CreateProductB(IEnumerable<string> idetifiers = null, string name = "DefaultName")
        {
            return new ProductB1(idetifiers, name);
        }
    }
}
