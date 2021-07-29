using System;
using System.Linq;

namespace SRP_Example_03
{
    internal class PriceCalculator
    {
        public PriceHolder PriceHolder { get; }

        public PriceCalculator(PriceHolder priceHolder)
        {
            this.PriceHolder = priceHolder;
        }

        public decimal CalculatePrice()
        {
            return this.PriceHolder.PriceList.Sum();
        }

        public void PrintPrice(decimal price)
        {
            Console.WriteLine($"Total amount: {price:C}");
        }
    }
}
