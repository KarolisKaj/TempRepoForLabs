using System;
using System.Threading;

namespace Plukas1Client.Products
{
    class CandyChocolade : CandyBase
    {
        public CandyChocolade(string name, string chocoladeType) : base(name)
        {
            ChocoladeType = chocoladeType;
        }

        protected CandyChocolade(CandyChocolade from) : base(from.Name)
        {
            ChocoladeType = from.ChocoladeType;
        }
        public string ChocoladeType { get; set; }

        public override object Clone()
        {
            return new CandyChocolade(this);
        }

        public override bool Eat(int time)
        {
            Thread.Sleep(500);
            return true;
        }
    }
}
