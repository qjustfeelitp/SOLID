using System;

namespace DIP_Example_01
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            var     priceCalculator = new PriceCalculator();
            decimal totalPrice      = priceCalculator.CalculateItems(100, decimal.MaxValue / 10000);

            Console.WriteLine($"Total price is {totalPrice}");
        }
    }
}
