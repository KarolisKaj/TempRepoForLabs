namespace Plukas1Client
{
    using Values;

    internal class BootStrapper
    {
        public BootStrapper(string family)
        {

            switch (family)
            {
                case "CaramelAlcoholChicken":
                    FactoryServiceSingleton.ProductFactory.CreateCandy(new object[] { "Caramel", "Fruits", 50 });
                    FactoryServiceSingleton.ProductFactory.CreateCandy(new object[] { "Boom", "Whiskey", 37 });
                    FactoryServiceSingleton.ProductFactory.CreateCandy(new object[] { 17, Served.Cold });
                    break;
                case "CaramelEnergyChicken":
                case "ChocoladeEnergyChicken":
                case "ChocoladeAlcoholChicken":
                case "CaramleAlchoholBeef":
                default:
                    break;
            }
        }
    }
}