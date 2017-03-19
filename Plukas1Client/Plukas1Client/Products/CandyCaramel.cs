namespace Plukas1Client.Products
{
    public class CandyCaramel : CandyBase
    {
        public CandyCaramel(string name, string covering) : base(name)
        {
            Covering = covering;
        }

        public string Covering { get; set; }

        public override object Clone()
        {
            return new CandyCaramel((base.Clone() as CandyBase)?.Name, this.Covering);
        }
    }
}
