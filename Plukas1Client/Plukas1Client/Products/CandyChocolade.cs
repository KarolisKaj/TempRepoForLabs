namespace Plukas1Client.Products
{
    class CandyChocolade : CandyBase
    {
        public CandyChocolade(string name, string chocoladeType) : base(name)
        {
            ChocoladeType = chocoladeType;
        }

        public string ChocoladeType { get; set; }

        public override object Clone()
        {
            return new CandyChocolade((base.Clone() as CandyBase)?.Name, ChocoladeType);
        }
    }
}
