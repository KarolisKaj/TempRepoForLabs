namespace Plukas1Client.FactoryStructs
{
    using System.Collections.Generic;
    using Products;

    public class AFamilyFactory : IProductFactory
    {
        private string _defaultName = "DefaultName";
        private int _number = 15;

        public ProductABase CreateProductA()
        {
            return new ProductA0(_defaultName, _number);
        }

        public ProductABase CreateProductA(string name)
        {
            return new ProductA0(name, _number);
        }

        public ProductABase CreateProductA(int number)
        {
            return new ProductA0(_defaultName, number);
        }

        public ProductABase CreateProductA(string name, int number)
        {
            return new ProductA0(name, number);
        }

        public ProductABase CreateProductA(string name, string color)
        {
            return new ProductA1(name, color);
        }

        public ProductBBase CreateProductB()
        {
            return new ProductB0(new string[] { _defaultName });
        }

        public ProductBBase CreateProductB(IEnumerable<string> idetifiers)
        {
            return new ProductB0(idetifiers);
        }

        public ProductBBase CreateProductB(IEnumerable<string> idetifiers, string name)
        {
            return new ProductB1(idetifiers, name);
        }
    }
}
