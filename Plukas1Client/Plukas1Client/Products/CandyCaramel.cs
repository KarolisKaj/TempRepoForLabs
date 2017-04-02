using System;

namespace Plukas1Client.Products
{
    public class CandyCaramel : CandyBase
    {
        public CandyCaramel(string name, string covering, int size) : base(name)
        {
            Covering = covering;
            Size = size;
        }
        // throw new check if client receives good execption.
        protected CandyCaramel(CandyCaramel from) : base(from)
        {
            Covering = from.Covering;
            Size = from.Size;
        }

        public string Covering { get; set; }
        public int Size { get; set; }

        public override object Clone()
        {
            return new CandyCaramel(this);
        }

        public override bool Eat(int time)
        {
            throw new NotImplementedException();
        }
    }
}
