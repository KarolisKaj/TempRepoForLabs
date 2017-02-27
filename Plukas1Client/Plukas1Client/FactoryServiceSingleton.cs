namespace Plukas1Client
{
    using FactoryStructs;
    using Products;
    public class FactoryServiceSingleton
    {
        private FactoryServiceSingleton() { }

        private static object _lockRoot = new object();
        private static IProductFactory _productFactory;
        public static IProductFactory ProductFactory
        {
            get
            {
                lock (_lockRoot)
                {
                    if (_productFactory == null)
                        _productFactory = new AFamilyFactory();
                    return _productFactory;
                }
            }
        }

    }
}
