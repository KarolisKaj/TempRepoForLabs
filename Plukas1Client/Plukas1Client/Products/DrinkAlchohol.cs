namespace Plukas1Client.Products
{
    class DrinkAlchohol : DrinkBase
    {
        public DrinkAlchohol(string name, string type, bool allowUnderage, int alcoholPercentage) : base(name, allowUnderage)
        {
            Type = type;
            AlcoholPercentage = alcoholPercentage;
        }
        public int AlcoholPercentage { get; set; }
        public string Type { get; set; }
    }
}
