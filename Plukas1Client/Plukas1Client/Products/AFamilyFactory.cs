namespace Plukas1Client.Products
{
    public class AFamilyFactory
    {
        private string Name { get; set; }
        public AFamilyFactory(string name)
        {
            Name = name;
        }
        public AFamilyFactory()
        {
            Name = name;
        }

        
        public ProductBase GetProduct()
        {
            return new ProductA(Name, "Yellow");
        }
    }
}
