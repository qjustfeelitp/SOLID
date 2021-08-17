using System.Linq;

namespace OCP_Example_02
{
    internal class ReceivedOrderCalculator : DocumentCalculator
    {
        /// <inheritdoc />
        public override decimal CalculatePrice(IDocument document)
        {
            return document.ItemPrices.Max() - document.Vat;
        }
    }
}
