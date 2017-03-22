namespace Plukas1Client.Products
{
    public class DrinkBase
    {
        public DrinkBase(string name)
        {
            Name = name;
        }
        public string Name { get; set; }

        public DrinkBase Clone()
        {
            return new DrinkBase(this.Name);
        }
    }
}
