using System.Collections.Generic;

namespace OPC_Example_01
{
    internal class Document
    {
        public DocumentType DocumentType { get; }

        public decimal Price { get; set; }

        public IEnumerable<decimal> ItemPrices { get; }
        public decimal Vat { get; }

        public Document(DocumentType documentType, IEnumerable<decimal> itemPrices, decimal vat)
        {
            this.DocumentType = documentType;
            this.ItemPrices   = itemPrices;
            this.Vat          = vat;
        }
    }
}
