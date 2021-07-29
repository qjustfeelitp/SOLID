using System.Linq;

namespace DIP_Example_02
{
    internal class PriceCalculator
    {
        private IItemLoader Loader { get; }

        public PriceCalculator(IItemLoader loader)
        {
            this.Loader = loader;
        }

        public decimal CalculateItems(int take, decimal upperRange)
        {
            return this.Loader.GetItemsWithPriceGreaterThan(take, upperRange).Sum(x => x.Price);
        }
    }
}
