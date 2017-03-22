using Plukas1Client.Products;
using Plukas1Client.Values;

namespace Plukas1Client.FactoryStructs
{
    public class CandyDrinkAndMeatConcreteFactory : IMeatCandyAndDrinkFactory
    {
        public CandyBase CreateCandy(params object[] args)
        {
            return new CandyCaramel((string)args[0], (string)args[1], (int)args[2]);
        }

        public DrinkBase CreateDrink(params object[] args)
        {
            return new DrinkAlchohol((string)args[0], (string)args[1], (int)args[2]);
        }

        public MeatBase CreateMeat(params object[] args)
        {
            return new MeatChicken((int)args[0], (Served)args[1]);

        }
    }
}
