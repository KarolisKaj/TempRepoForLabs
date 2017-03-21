namespace Plukas1Client.FactoryStructs
{
    using System;
    using Products;

    public class ConcreteMeatCandyAndDrink : IMeatCandyAndDrinkFactory
    {
        public CandyBase CreateCandy(params object[] args)
        {
            throw new NotImplementedException();
        }

        public DrinkBase CreateDrink(params object[] args)
        {
            throw new NotImplementedException();
        }

        public MeatBase CreateMeat(params object[] args)
        {
            throw new NotImplementedException();
        }
    }
}
