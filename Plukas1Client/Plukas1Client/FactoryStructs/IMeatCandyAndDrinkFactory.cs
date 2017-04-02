using Plukas1Client.Products;
using System.Collections.Generic;

namespace Plukas1Client.FactoryStructs
{
    public interface IMeatCandyAndDrinkFactory
    {
        // Actual params
        CandyBase CreateCandy(string name);
        MeatBase CreateMeat(int id, int fat);
        DrinkBase CreateDrink(string name, bool allowedUnderaged);
    }
}
