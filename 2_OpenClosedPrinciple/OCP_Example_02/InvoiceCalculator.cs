using System.Linq;

namespace OCP_Example_02
{
    internal class InvoiceCalculator : DocumentCalculator
    {
        /// <inheritdoc />
        public override decimal CalculatePrice(IDocument document)
        {
            return document.ItemPrices.Sum() + document.Vat;
        }
    }
}
