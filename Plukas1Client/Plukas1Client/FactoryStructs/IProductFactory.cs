using Plukas1Client.Products;
using System.Collections.Generic;

namespace Plukas1Client.FactoryStructs
{
    public interface IProductFactory
    {
        CandyBase CreateCandy(string name, string covering);
        DrinkBase CreateDrink(string name, string type, int alcoholPercentage);
    }
}
