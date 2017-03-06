using Plukas1Client.FactoryStructs;
using System;
using System.Linq;

namespace Plukas1Client
{
    internal class BootStrapper
    {
        public BootStrapper(params object[] args)
        {
            var request = args[0] as string;
            //var factory = Dependencies.RegisteredDependencies[request];
            object[] arr = new object[args.Length];
            arr[0] = (Type.GetType(args[0] as string, false, false) as object);
            Array.Copy(args, 1, arr, 1, args.Length - 1);
            var j = new BCFamilyFactory().CreateProductA(arr);
            System.Console.WriteLine(j);
        }
    }
}