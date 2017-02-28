namespace Plukas1Client.FactoryStructs
{
    using Products;

    public class AFamilyFactory : IProductFactory
    {
        private string _defaultName = "DefaultName";
        private int _number = 15;

        public ProductABase CreateProductA()
        {
            return new ProductA0(_defaultName, _number);
        }

        public ProductABase CreateProductA(int number)
        {
            return new ProductA0(_defaultName, number);
        }

        public ProductBBase CreateProductB()
        {
            return new ProductB0(new string[] { _defaultName });
        }
    }
}
