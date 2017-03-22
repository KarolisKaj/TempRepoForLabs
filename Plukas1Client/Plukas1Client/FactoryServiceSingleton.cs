namespace Plukas1Client
{
    using FactoryStructs;

    public class FactoryServiceSingleton
    {
        private FactoryServiceSingleton() { }

        private static object _lockRoot = new object();
        private static IMeatCandyAndDrinkFactory _productFactory;
        public static IMeatCandyAndDrinkFactory ProductFactory
        {
            get
            {
                if (_productFactory == null)
                    lock (_lockRoot)
                        if (_productFactory == null)
                            _productFactory = new CandyDrinkAndMeatTypeFactory();

                return _productFactory;
            }
        }
    }
}
