using Plukas1Client.Products;

namespace Plukas1Client.Creators
{
    public class DrinkEnergyCreator : ICreator
    {
        public object Create(object[] args)
        {
            return new DrinkEnergy(args[0] as string, (int)args[1]);
        }
    }
}
