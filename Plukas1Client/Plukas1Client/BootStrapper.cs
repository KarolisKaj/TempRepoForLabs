namespace Plukas1Client
{
    using Products;
    using Values;

    internal class BootStrapper
    {
        public BootStrapper(string family)
        {

            switch (family)
            {
                case "CaramelAlcoholChicken":
                    FactoryServiceSingleton.ProductFactory.CreateCandy(new object[] {"Caramel", "Fruits", 50 });
                    FactoryServiceSingleton.ProductFactory.CreateDrink(new object[] { "Boom", "Whiskey", 37 });
                    FactoryServiceSingleton.ProductFactory.CreateMeat(new object[] { 17, Served.Cold });
                    break;
                case "CaramelEnergyChicken":
                case "ChocoladeEnergyChicken":
                case "ChocoladeAlcoholChicken":
                case "CaramelAlchoholBeef":
                default:
                    break;
            }
        }
    }
}