namespace Plukas1Client.Products
{
    class DrinkEnergy : DrinkBase
    {
        public DrinkEnergy(string name, int caffeineAmount) : base(name)
        {
            CaffeineAmount = caffeineAmount;
        }

        public int CaffeineAmount { get; set; }
    }
}
