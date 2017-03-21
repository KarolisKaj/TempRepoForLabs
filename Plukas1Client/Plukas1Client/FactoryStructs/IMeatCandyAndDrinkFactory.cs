using Plukas1Client.Products;
using System.Collections.Generic;

namespace Plukas1Client.FactoryStructs
{
    public interface IMeatCandyAndDrinkFactory
    {
        CandyBase CreateCandy(params object[] args);
        MeatBase CreateMeat(params object[] args);
        DrinkBase CreateDrink(params object[] args);
    }
}
