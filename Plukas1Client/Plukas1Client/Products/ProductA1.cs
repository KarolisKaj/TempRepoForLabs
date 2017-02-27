namespace Plukas1Client.Products
{
    class ProductA1 : ProductABase
    {
        public ProductA1(string name) : base(name)
        {
            Count = name?.Length ?? default(int);
        }

        public ProductA1(string name, string color) : this(name)
        {
            Color = color;
        }

        public string Color { get; set; } = "Black";
        public int Count { get; set; }

        public override object Clone()
        {
            return new ProductA1((base.Clone() as ProductABase)?.Name) { Count = this.Count, Color = this.Color };
        }
    }
}
