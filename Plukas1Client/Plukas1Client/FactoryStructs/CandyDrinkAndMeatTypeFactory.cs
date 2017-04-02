namespace Plukas1Client.FactoryStructs
{
    using System;
    using Products;
    using System.Linq;

    public class CandyDrinkAndMeatTypeFactory : IMeatCandyAndDrinkFactory
    {
        public CandyDrinkAndMeatTypeFactory(Type candyTypes, Type meatTypes, Type drinkTypes, object[] meatArgs = null, object[] candyArgs = null, object[] drinkArgs = null)
        {
            CandyTypes = candyTypes;
            MeatTypes = meatTypes;
            DrinkTypes = drinkTypes;
            MeatDefaults = meatArgs;
            CandyDefaults = candyArgs;
            DrinkDefaults = drinkArgs;
        }

        public object[] MeatDefaults { get; set; }
        public object[] CandyDefaults { get; set; }
        public object[] DrinkDefaults { get; set; }
        public Type CandyTypes { get; }
        public Type MeatTypes { get; }
        public Type DrinkTypes { get; }


        // DRY, sorry! :(((
        public CandyBase CreateCandy(object[] args = null)
        {
            foreach (var candyType in CandyTypes)
            {
                try
                {
                    if (args == null || args.Length == 0)
                    {
                        if (CandyDefaults != null && CandyDefaults.Length > 0)
                            return (candyType.GetConstructor(CandyDefaults.Select(x => x.GetType()).ToArray()).Invoke(args.ToArray()) as CandyBase);
                    }
                    else
                    {
                        return (candyType.GetConstructor(args.Select(x => x.GetType()).ToArray()).Invoke(args.ToArray()) as CandyBase);
                    }
                }
                catch { continue; }
            }
            throw new ArgumentException("No matching type found.");
        }


        public DrinkBase CreateDrink(object[] args = null)
        {
            foreach (var drinkType in DrinkTypes)
            {
                try
                {
                    if (args == null || args.Length == 0)
                    {
                        if (DrinkDefaults != null && DrinkDefaults.Length > 0)
                            return (drinkType.GetConstructor(DrinkDefaults.Select(x => x.GetType()).ToArray()).Invoke(DrinkDefaults.ToArray()) as DrinkBase);
                    }
                    else
                    {
                        return (drinkType.GetConstructor(args.Select(x => x.GetType()).ToArray()).Invoke(args.ToArray()) as DrinkBase);
                    }
                }
                catch { continue; }
            }
            throw new ArgumentException("No matching type found.");
        }

        public MeatBase CreateMeat(object[] args = null)
        {
            foreach (var meatType in MeatTypes)
            {
                try
                {
                    if (args == null || args.Length == 0)
                    {
                        if (MeatDefaults != null && MeatDefaults.Length > 0)
                            return (meatType.GetConstructor(MeatDefaults.Select(x => x.GetType()).ToArray()).Invoke(MeatDefaults.ToArray()) as MeatBase);
                    }
                    else
                    {
                        return (meatType.GetConstructor(args.Select(x => x.GetType()).ToArray()).Invoke(args.ToArray()) as MeatBase);
                    }
                }
                catch { continue; }
            }
            throw new ArgumentException("No matching type found.");
        }

        public CandyBase CreateCandy(string name)
        {
            throw new NotImplementedException();
        }

        public MeatBase CreateMeat(int id, int fat)
        {
            throw new NotImplementedException();
        }

        public DrinkBase CreateDrink(string name, bool allowedUnderaged)
        {
            throw new NotImplementedException();
        }
    }
}
