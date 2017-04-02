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

        public CandyBase CreateCandy(string name = null)
        {
            var objectToInit = _initializedObjects.SingleOrDefault(x => x.GetType().IsAssignableFrom(typeof(CandyBase)));
            return ((objectToInit as CandyBase).Clone() as CandyBase);
        }

        public DrinkBase CreateDrink(string name = null, bool allowedUnderaged = false)
        {
            throw new NotImplementedException();
        }

        public MeatBase CreateMeat(int id, int fat)
        {
            var objectToInit = _initializedObjects.SingleOrDefault(x => x.GetType().IsAssignableFrom(typeof(MeatBase)));
            return ((objectToInit as MeatBase).Clone() as MeatBase);
        }
    }
}
