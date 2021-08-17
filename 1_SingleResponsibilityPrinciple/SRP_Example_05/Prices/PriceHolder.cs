using System.Collections.Generic;

namespace SRP_Example_05.Prices
{
    internal class PriceHolder
    {
        public List<decimal> PriceList { get; }

        public PriceHolder(IEnumerable<decimal> prices)
        {
            this.PriceList = new List<decimal>(prices);
        }
    }
}
