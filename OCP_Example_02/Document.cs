using System.Collections.Generic;

namespace OCP_Example_02
{
    internal abstract class Document : IDocument
    {
        public decimal Price
        {
            get { return this.Calculator.CalculatePrice(this); }
        }

        public IEnumerable<decimal> ItemPrices { get; }
        public decimal Vat { get; }

        protected abstract IDocumentCalculator Calculator { get; }

        protected Document(IEnumerable<decimal> itemPrices, decimal vat)
        {
            this.ItemPrices = itemPrices;
            this.Vat        = vat;
        }
    }
}
