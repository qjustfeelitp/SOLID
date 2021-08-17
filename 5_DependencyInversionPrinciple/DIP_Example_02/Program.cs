using System;

namespace DIP_Example_02
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            var dataAccess       = new DataAccess();
            var cachedDataAccess = new DataAccessCached(dataAccess);
            var itemLoader       = new ItemLoader(cachedDataAccess);
            var priceCalculator  = new PriceCalculator(itemLoader);

            decimal totalPrice = priceCalculator.CalculateItems(100, decimal.MaxValue / 10000);

            Console.WriteLine($"Total price is {totalPrice}");

            totalPrice = priceCalculator.CalculateItems(100, decimal.MaxValue / 10000);

            Console.WriteLine($"Total price is {totalPrice}");

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(new string('-', 100));
            Console.WriteLine(Environment.NewLine);

            var itemLoaderWithoutCachedDataAccess      = new ItemLoader(dataAccess);
            var priceCalculatorWithoutCachedDataAccess = new PriceCalculator(itemLoaderWithoutCachedDataAccess);

            decimal totalPriceWithoutCachedDataAccess = priceCalculatorWithoutCachedDataAccess.CalculateItems(100, decimal.MaxValue / 10000);

            Console.WriteLine($"Total price is {totalPriceWithoutCachedDataAccess}");

            totalPriceWithoutCachedDataAccess = priceCalculatorWithoutCachedDataAccess.CalculateItems(100, decimal.MaxValue / 10000);

            Console.WriteLine($"Total price is {totalPriceWithoutCachedDataAccess}");
        }
    }
}
