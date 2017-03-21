using System;
using Plukas1Client.Products;
using System.Linq;
using System.Collections.Generic;

namespace Plukas1Client.FactoryStructs
{
    class CandyDrinkAndMeatUniversalFactory : IProductParametrizedFactory
    {
        private object[] DefaultCandyParams { get; set; } = new object[] { "One", "Two" };

        public CandyBase CreateCandy(params object[] args)
        {
            if (args.Length != 1)
                return ((args[0] as Type).GetConstructor(args.Skip(1).Select(x => x.GetType()).ToArray())
                .Invoke(args.Skip(1).ToArray()) as CandyBase);
            else
                return ((args[0] as Type).GetConstructor(DefaultCandyParams.Select(x => x.GetType()).ToArray())
               .Invoke(DefaultCandyParams) as CandyBase);
        }

        private object[] DefaultMeatParams { get; set; } = new object[] {  };
        public MeatBase CreateMeat(params object[] args)
        {
            if (args.Length != 1)
                return ((args[0] as Type).GetConstructor(args.Skip(1).Select(x => x.GetType()).ToArray())
                    .Invoke(args.Skip(1).ToArray()) as MeatBase);
            else
                return ((args[0] as Type).GetConstructor(DefaultMeatParams.Select(x => x.GetType()).ToArray())
                     .Invoke(DefaultMeatParams) as MeatBase);
        }

        public DrinkBase CreateDrink(params object[] args)
        {
            throw new NotImplementedException();
        }
    }
}
