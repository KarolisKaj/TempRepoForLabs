namespace Plukas1Client
{
    internal class BootStrapper
    {
        public BootStrapper(params object[] args)
        {
            var request = args[0] as string;
            var factory = Dependencies.RegisteredDependencies[request];
        }
    }
}