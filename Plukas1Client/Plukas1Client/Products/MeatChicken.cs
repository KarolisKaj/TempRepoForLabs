namespace Plukas1Client.Products
{
    using Values;
    public class MeatChicken : MeatBase
    {
        public MeatChicken(int meatID, Served bestServed) : base(meatID)
        {
            BestServed = bestServed;
        }

        public Served BestServed { get; set; }

        public string Name { get; set; }
    }
}
