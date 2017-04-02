namespace Plukas1Client.FactoryStructs
{
    using System;
    using Products;
    using System.Collections.Generic;
    using System.Linq;

    public class CandyDrinkAndMeatClonableFactory : IMeatCandyAndDrinkFactory
    {
        private IEnumerable<object> _initializedObjects;
        public CandyDrinkAndMeatClonableFactory(IEnumerable<object> initializedObjects)
        {
            _initializedObjects = initializedObjects;
        }

        public CandyBase CreateCandy(params object[] args)
        {
            // CandyBase lookup
            var typeToInit = Type.GetType(args[0] as string);
            return ((_initializedObjects.FirstOrDefault(x => x.GetType() == typeToInit) as CandyBase).Clone() as CandyBase);
        }

        public DrinkBase CreateDrink(params object[] args)
        {
            var typeToInit = Type.GetType(args[0] as string);
            return ((_initializedObjects.FirstOrDefault(x => x.GetType() == typeToInit) as DrinkBase).Clone() as DrinkBase);
        }

        public MeatBase CreateMeat(params object[] args)
        {
            var typeToInit = typeof(MeatBase);
            return ((_initializedObjects.FirstOrDefault(x => x.GetType() == typeToInit) as MeatBase).Clone() as MeatBase);
        }
    }
}
