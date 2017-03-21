namespace Plukas1Client.Products
{
    public class CandyCaramel : CandyBase
    {
        public CandyCaramel(string name, string covering, int size) : base(name)
        {
            Covering = covering;
            Size = size;
        }

        public string Covering { get; set; }
        public int Size { get; set; }

        public override object Clone()
        {
            return new CandyCaramel((base.Clone() as CandyBase)?.Name, this.Covering, this.Size);
        }
    }
}
