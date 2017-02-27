namespace Plukas1Client.FactoryStructs
{
    using Products;

    public class AFamilyFactory : IProductFactory
    {

        public ProductABase CreateProductA()
        {
            return new ProductA0(_defaultName);
        }

        public ProductBBase CreateProductB()
        {
            return new ProductB0(new string[] { _defaultName });
        }
    }
}
