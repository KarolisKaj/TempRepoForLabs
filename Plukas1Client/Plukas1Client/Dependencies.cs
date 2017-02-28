using Plukas1Client.Products;
using System;
using System.Collections.Generic;

namespace Plukas1Client
{
    public class Dependencies
    {
        private Dictionary<string, Type[]> _registeredDependencies;
        public Dictionary<string, Type[]> RegisteredDependencies { get { return _registeredDependencies; } }
        public void InitializeGroups()
        {
            _registeredDependencies.Add("A", new Type[] { typeof(ProductA0) });
        }
    }
}
