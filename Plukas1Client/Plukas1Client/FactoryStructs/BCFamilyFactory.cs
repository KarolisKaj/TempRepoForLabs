using Plukas1Client.FactoryStructs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plukas1Client.Products;

namespace Plukas1Client.FactoryStructs
{
    class BCFamilyFactory : IProductFactory
    {
        public ProductABase CreateProductA(string name)
        {
        }

        public ProductBBase CreateProductB(IEnumerable<string> identifiers)
        {
            throw new NotImplementedException();
        }
    }
}
