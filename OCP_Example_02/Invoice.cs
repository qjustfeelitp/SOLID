using System.Collections.Generic;

namespace OCP_Example_02
{
    internal class Invoice : Document
    {
        private IDocumentCalculator documentCalculator;

        /// <inheritdoc />
        protected override IDocumentCalculator Calculator
        {
            get { return this.documentCalculator ??= new InvoiceCalculator(); }
        }

        /// <inheritdoc />
        public Invoice(IEnumerable<decimal> itemPrices, decimal vat) : base(itemPrices, vat)
        {
        }
    }
}
