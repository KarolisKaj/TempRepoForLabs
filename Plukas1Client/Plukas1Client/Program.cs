namespace Plukas1Client
{
    using System;
    using System.Threading.Tasks;

    class Program
    {
        static void Main(params object[] args)
        {
            Task.Run(() => new BootStrapper(args));
            Console.ReadLine();
        }
    }
}
