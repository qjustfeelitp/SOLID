using System.Collections.Generic;

namespace OCP_Example_03
{
    internal class IssueSlip : Document
    {
        /// <inheritdoc />
        public IssueSlip(IEnumerable<decimal> itemPrices, decimal vat) : base(itemPrices, vat)
        {
        }
    }
}
