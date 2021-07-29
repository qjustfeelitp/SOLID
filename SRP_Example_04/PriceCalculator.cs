using System.Linq;

namespace SRP_Example_04
{
    internal class PriceCalculator
    {
        public decimal CalculatePrice(PriceHolder priceHolder)
        {
            return priceHolder.PriceList.Sum();
        }
    }
}
