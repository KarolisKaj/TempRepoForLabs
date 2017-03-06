namespace Plukas1Client
{
    using FactoryStructs;
    using System;
    using System.Linq;

    public class FactoryServiceSingleton
    {
        private FactoryServiceSingleton() { }

        private static object _lockRoot = new object();
        private static IProductFactory _productFactory;
        public static IProductFactory ProductFactory
        {
            get
            {
                if (_productFactory == null)
                    lock (_lockRoot)
                        if (_productFactory == null)
                            _productFactory = new AFamilyFactory();

                return _productFactory;
            }
        }

        public void InjectDP(string className, object[] args = null)
        {
            _productFactory = Type.GetType(className)
                .GetConstructor(args?.Select(x => x?.GetType())?.ToArray())
                .Invoke(args) as IProductFactory;
        }

    }
}
