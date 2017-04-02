using System;
using System.Linq;

namespace Plukas1Client.Creators
{
    public class AbstractCreator : ICreator
    {
        private Type CreateItem { get; set; }
        public AbstractCreator(Type createItem)
        {
            CreateItem = createItem;
        }
        public object Create(object[] args)
        {
            return CreateItem.GetConstructor(args.Select(x => x.GetType()).ToArray()).Invoke(args);
        }
    }
}
