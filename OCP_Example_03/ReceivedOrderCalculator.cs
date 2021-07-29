using System.Linq;

namespace OCP_Example_03
{
    internal class ReceivedOrderCalculator : DocumentCalculator<ReceivedOrder>
    {
        /// <inheritdoc />
        public override void CalculatePrice(ReceivedOrder document)
        {
            document.Price = document.ItemPrices.Max() - document.Vat;
        }
    }
}
