using System.Collections.Generic;

namespace OCP_Example_02
{
    internal class IssueSlip : Document
    {
        private IDocumentCalculator documentCalculator;

        /// <inheritdoc />
        protected override IDocumentCalculator Calculator
        {
            get { return this.documentCalculator ??= new IssueSlipCalculator(); }
        }

        /// <inheritdoc />
        public IssueSlip(IEnumerable<decimal> itemPrices, decimal vat) : base(itemPrices, vat)
        {
        }
    }
}
