using System.Collections.Generic;

namespace OCP_Example_03
{
    internal abstract class Document : IDocument
    {
        public decimal Price { get; set; }

        public IEnumerable<decimal> ItemPrices { get; }
        public decimal Vat { get; }

        protected Document(IEnumerable<decimal> itemPrices, decimal vat)
        {
            this.ItemPrices = itemPrices;
            this.Vat        = vat;
        }
    }
}
