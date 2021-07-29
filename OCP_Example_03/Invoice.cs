using System.Collections.Generic;

namespace OCP_Example_03
{
    internal class Invoice : Document
    {
        /// <inheritdoc />
        public Invoice(IEnumerable<decimal> itemPrices, decimal vat) : base(itemPrices, vat)
        {
        }
    }
}
