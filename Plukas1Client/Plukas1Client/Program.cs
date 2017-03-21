namespace Plukas1Client
{
    using Products;
    using System;
    using System.Threading.Tasks;

    class Program
    {
        static void Main(params string[] args)
        {
            Task.Run(() => new BootStrapper(args));
            Console.ReadLine();
        }
    }
}
