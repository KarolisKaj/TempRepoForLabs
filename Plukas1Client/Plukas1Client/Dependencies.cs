using Plukas1Client.FactoryStructs;
using System.Collections.Generic;

namespace Plukas1Client
{
    public static class Dependencies
    {
        static Dependencies()
        {
            InitializeGroups();
        }

        private static Dictionary<string, IFactory> _registeredDependencies;
        public static Dictionary<string, IFactory> RegisteredDependencies { get { return _registeredDependencies; } }

        private static void InitializeGroups()
        {
            _registeredDependencies.Add("A", FactoryServiceSingleton.ProductFactory);
            _registeredDependencies.Add("B", new BCFamilyFactory());
            _registeredDependencies.Add("C", new BCFamilyFactory());
            _registeredDependencies.Add("D", new DEFamilyFactory());
            _registeredDependencies.Add("E", new DEFamilyFactory());
            _registeredDependencies.Add("F", FactoryServiceSingleton.ProductFactory);
        }
    }
}
