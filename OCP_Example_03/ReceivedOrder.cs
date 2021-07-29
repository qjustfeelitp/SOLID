using System.Collections.Generic;

namespace OCP_Example_03
{
    internal class ReceivedOrder : Document
    {
        /// <inheritdoc />
        public ReceivedOrder(IEnumerable<decimal> itemPrices, decimal vat) : base(itemPrices, vat)
        {
        }
    }
}
