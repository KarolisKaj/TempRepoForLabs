using System;
using System.Collections.Generic;

namespace Plukas1Client.Creators
{
    class Trader<T> : ITrader<T>
    {
        private Dictionary<Type, ICreator> map = new Dictionary<Type, ICreator>();
        public T Create(T type, object[] args)
        {
            return (T)map[typeof(T)].Create(args);
        }
    }
}
