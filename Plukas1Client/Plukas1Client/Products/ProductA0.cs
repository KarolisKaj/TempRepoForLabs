namespace Plukas1Client.Products
{
    public class ProductA0 : ProductABase
    {
        public ProductA0(string name, int number) : base(name)
        {
            Number = number;
        }

        public int Number { get; set; }

        public override object Clone()
        {
            return new ProductA0((base.Clone() as ProductABase)?.Name, Number);
        }
    }
}
