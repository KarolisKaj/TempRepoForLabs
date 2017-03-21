namespace Plukas1Client
{
    using Products;
    using System;
    using System.Threading.Tasks;

    class Program
    {
        static void Main(params string[] args)
        {
            var candySomething = typeof(CandyBase).GetConstructor(new Type[] { typeof(string), typeof(string) }).Invoke(new object[] {"Chocko", "white" });

            Task.Run(() => new BootStrapper(args));
            Console.ReadLine();
        }
    }
}
