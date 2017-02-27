using System;

namespace Plukas1Client
{
    internal class BootStrapper
    {
        public BootStrapper(string[] args)
        {
            FactoryServiceSingleton.ProductFactory.CreateProduct(args);
        }
    }
}