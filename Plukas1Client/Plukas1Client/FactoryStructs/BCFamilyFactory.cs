using System;
using Plukas1Client.Products;
using System.Linq;
using System.Collections.Generic;

namespace Plukas1Client.FactoryStructs
{
    class BCFamilyFactory : IProductParametrizedFactory
    {
        private object[] ADefaultArgs { get; set; } = new object[] { "One", "Two" };

        public CandyBase CreateProductA(params object[] args)
        {
            if (args.Length != 1)
                return ((args[0] as Type).GetConstructor(args.Skip(1).Select(x => x.GetType()).ToArray())
                .Invoke(args.Skip(1).ToArray()) as CandyBase);
            else
                return ((args[0] as Type).GetConstructor(ADefaultArgs.Select(x => x.GetType()).ToArray())
               .Invoke(ADefaultArgs) as CandyBase);
        }

        private object[] BDefaultArgs { get; set; } = new object[] { (IEnumerable<string>)new List<string>() { "Hello" }, 5 };
        public MeatBase CreateProductB(params object[] args)
        {
            if (args.Length != 1)
                return ((args[0] as Type).GetConstructor(args.Skip(1).Select(x => x.GetType()).ToArray())
                    .Invoke(args.Skip(1).ToArray()) as MeatBase);
            else
                return ((args[0] as Type).GetConstructor(BDefaultArgs.Select(x => x.GetType()).ToArray())
                     .Invoke(BDefaultArgs) as MeatBase);
        }
    }
}
