namespace Plukas1Client.FactoryStructs
{
    using Products;
    using System.Linq;

    public class CandyDrinkAndMeatConcreteFactory : IMeatCandyAndDrinkFactory
    {
        public CandyDrinkAndMeatConcreteFactory(object[] meatDefaults = null, object[] drinkDefaults = null, object[] candyDefaults = null)
        {
            MeatDefaults = meatDefaults;
            DrinkDefaults = drinkDefaults;
            CandyDefaults = candyDefaults;
        }

        public object[] MeatDefaults { get; set; }
        public object[] DrinkDefaults { get; set; }
        public object[] CandyDefaults { get; set; }

        public CandyBase CreateCandy(string name)
        {
            if (CandyDefaults != null && CandyDefaults?.Count(x => x.GetType() == typeof(string)) == 2)
                new CandyChocolade(CandyDefaults[0] as string, CandyDefaults[1] as string);
            return new CandyCaramel(name, "Vafle", 100);
        }
        public DrinkBase CreateDrink(string name, bool allowedUnderaged)
        {
            return new DrinkAlchohol(name, "Whiskey", allowedUnderaged, 35);
        }
        public MeatBase CreateMeat(int id, int fat)
        {
            return new MeatBeef(id, fat);
        }
    }
}
