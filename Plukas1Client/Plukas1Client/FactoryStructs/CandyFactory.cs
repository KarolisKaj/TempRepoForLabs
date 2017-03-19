namespace Plukas1Client.FactoryStructs
{
    using Products;

    public class CandyFactory : IProductFactory
    {

        public CandyBase CreateCandy(string name = "DefaultName", string covering = "Chocolade")
        {
            return new CandyCaramel(name, covering);
        }

        public DrinkBase CreateDrink(string name, string type = "Whiskey", int alcoholPercentage = 37)
        {
            return new DrinkAlchohol(name, type, alcoholPercentage);
        }
    }
}
