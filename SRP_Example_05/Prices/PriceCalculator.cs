using System.Linq;

namespace SRP_Example_05.Prices
{
    internal class PriceCalculator : IPriceCalculator
    {
        decimal IPriceCalculator.CalculatePrice(PriceHolder priceHolder)
        {
            return priceHolder.PriceList.Sum();
        }
    }
}
