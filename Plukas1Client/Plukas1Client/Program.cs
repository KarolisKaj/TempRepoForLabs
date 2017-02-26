namespace Plukas1Client
{
    using System;
    using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
            Task.Run(() => new BootStrapper(args));
            Console.ReadLine();
        }
    }
}
