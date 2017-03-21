namespace Plukas1Client
{
    using System;
    internal class BootStrapper
    {
        public BootStrapper(params object[] args)
        {

            var temp = new object[args.Length];
            temp[0] = Type.GetType(args[0] as string);
            Array.ConstrainedCopy(args, 1, temp, 1, temp.Length - 1);
            var j = FactoryServiceSingleton.ProductFactory.CreateCandy(temp);
            Console.WriteLine(j);
        }
    }
}