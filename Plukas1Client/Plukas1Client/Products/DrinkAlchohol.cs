namespace Plukas1Client.Products
{
    class DrinkAlchohol : DrinkBase
    {
        public DrinkAlchohol(string name, string type, int alcoholPercentage) : base(name)
        {
            Type = type;
            AlcoholPercentage = alcoholPercentage;
        }

        public int AlcoholPercentage { get; set; }
        public string Type { get; set; }
    }
}
