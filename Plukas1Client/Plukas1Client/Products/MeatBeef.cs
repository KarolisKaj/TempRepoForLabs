namespace Plukas1Client.Products
{
    public class MeatBeef : MeatBase
    {
        public MeatBeef(int meatID, int fatPercent) : base(meatID)
        {
            FatPercent = fatPercent;
        }

        public int FatPercent { get; set; }
    }
}

