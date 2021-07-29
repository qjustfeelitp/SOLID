using System.Collections.Generic;

namespace OCP_Example_02
{
    internal class ReceivedOrder : Document
    {
        private IDocumentCalculator documentCalculator;

        /// <inheritdoc />
        protected override IDocumentCalculator Calculator
        {
            get { return this.documentCalculator ??= new ReceivedOrderCalculator(); }
        }

        /// <inheritdoc />
        public ReceivedOrder(IEnumerable<decimal> itemPrices, decimal vat) : base(itemPrices, vat)
        {
        }
    }
}
