using System.Linq;

namespace OCP_Example_03
{
    internal class InvoiceCalculator : DocumentCalculator<Invoice>
    {
        /// <inheritdoc />
        public override void CalculatePrice(Invoice document)
        {
            document.Price = document.ItemPrices.Sum() + document.Vat;
        }
    }
}
