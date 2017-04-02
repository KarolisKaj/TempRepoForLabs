namespace Plukas1Client.Products
{
    public class DrinkBase
    {
        public DrinkBase(string name)
        {
            Name = name;
        }
        public DrinkBase(string name, bool allowUnderage) : this(name)
        {
            AllowUnderage = allowUnderage;
        }
        public string Name { get; set; }
        public bool AllowUnderage { get; set; } = true;
    }
}
