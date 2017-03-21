namespace Plukas1Client.FactoryStructs
{
    using System;
    using Products;
    using System.Linq;

    public class CandyDrinkAndMeatUniversalFactory : IMeatCandyAndDrinkFactory
    {
        public CandyDrinkAndMeatUniversalFactory(object[] meatArgs = null, object[] candyArgs = null, object[] drinkArgs = null)
        {
            MeatDefaults = meatArgs;
            CandyDefaults = candyArgs;
            DrinkDefaults = drinkArgs;
        }

        public object[] MeatDefaults { get; set; }
        public object[] CandyDefaults { get; set; }
        public object[] DrinkDefaults { get; set; }


        // DRY, sorry! :(((
        public CandyBase CreateCandy(params object[] args)
        {
            if (args == null || args.Length == 0)
            {
                if (CandyDefaults != null && CandyDefaults.Length > 0)
                    return ((CandyDefaults[0] as Type).GetConstructor(CandyDefaults.Skip(1).Select(x => x.GetType()).ToArray()).Invoke(args.Skip(1).ToArray()) as CandyBase);
            }
            else if (args.Length == 1)
            {
                return ((args[0] as Type).GetConstructor(CandyDefaults.Skip(1).Select(x => x.GetType()).ToArray()).Invoke(args.Skip(1).ToArray()) as CandyBase);
            }
            else if (args.Length > 1)
            {
                return ((args[0] as Type).GetConstructor(args.Skip(1).Select(x => x.GetType()).ToArray()).Invoke(args.Skip(1).ToArray()) as CandyBase);
            }
            throw new NotImplementedException("No matches found.");
        }

        public DrinkBase CreateDrink(params object[] args)
        {
            if (args == null || args.Length == 0)
            {
                if (DrinkDefaults != null && DrinkDefaults.Length > 0)
                    return ((DrinkDefaults[0] as Type).GetConstructor(DrinkDefaults.Skip(1).Select(x => x.GetType()).ToArray()).Invoke(args.Skip(1).ToArray()) as DrinkBase);
            }
            else if (args.Length == 1)
            {
                return ((args[0] as Type).GetConstructor(DrinkDefaults.Skip(1).Select(x => x.GetType()).ToArray()).Invoke(args.Skip(1).ToArray()) as DrinkBase);
            }
            else if (args.Length > 1)
            {
                return ((args[0] as Type).GetConstructor(args.Skip(1).Select(x => x.GetType()).ToArray()).Invoke(args.Skip(1).ToArray()) as DrinkBase);
            }
            throw new NotImplementedException("No matches found.");
        }

        public MeatBase CreateMeat(params object[] args)
        {
            if (args == null || args.Length == 0)
            {
                if (MeatDefaults != null && MeatDefaults.Length > 0)
                    return ((MeatDefaults[0] as Type).GetConstructor(MeatDefaults.Skip(1).Select(x => x.GetType()).ToArray()).Invoke(args.Skip(1).ToArray()) as MeatBase);
            }
            else if (args.Length == 1)
            {
                return ((args[0] as Type).GetConstructor(MeatDefaults.Skip(1).Select(x => x.GetType()).ToArray()).Invoke(args.Skip(1).ToArray()) as MeatBase);
            }
            else if (args.Length > 1)
            {
                return ((args[0] as Type).GetConstructor(args.Skip(1).Select(x => x.GetType()).ToArray()).Invoke(args.Skip(1).ToArray()) as MeatBase);
            }
            throw new NotImplementedException("No matches found.");
        }
    }
}
