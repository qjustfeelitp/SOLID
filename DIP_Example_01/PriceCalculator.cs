using System.Linq;

namespace DIP_Example_01
{
    internal class PriceCalculator
    {
        private ItemLoader itemLoader;

        private ItemLoader ItemLoader
        {
            get { return this.itemLoader ??= new ItemLoader(); }
        }

        public decimal CalculateItems(int take, decimal upperRange)
        {
            return this.ItemLoader.GetItemsWithPriceGreaterThan(take, upperRange).Sum(x => x.Price);
        }
    }
}
