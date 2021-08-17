using System;

namespace SRP_Example_04
{
    internal class PricePrinter
    {
        public void PrintPrice(decimal price)
        {
            Console.WriteLine($"Total amount: {price:C}");
        }
    }
}
