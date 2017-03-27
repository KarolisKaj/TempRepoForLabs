namespace Plukas1Client.Creators
{
    interface ITrader<T>
    {
        T Create(T type, object[] arg);
    }
}
