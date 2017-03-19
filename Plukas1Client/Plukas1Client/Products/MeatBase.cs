namespace Plukas1Client.Products
{
    using System;
    public abstract class MeatBase
    {
        public MeatBase(int meatID)
        {
            MeatID = meatID;
        }

        public int MeatID { get; set; }

        public virtual MeatBase Clone()
        {
            return this.Copy();
        }
    }
}
