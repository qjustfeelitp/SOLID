using System.Linq;

namespace SRP_Example_03
{
    /// <summary>
    /// What is wrong with this code?
    /// </summary>
    internal static class Program
    {
        public static void Main(string[] args)
        {
            var priceHolder     = new PriceHolder(Enumerable.Repeat(5m, 100));
            var priceCalculator = new PriceCalculator(priceHolder);

            decimal price           = priceCalculator.CalculatePrice();
            var     emailDataHolder = new EmailDataHolder("example@example.com", "Order placed", $"Your order with value of {price:C} has been placed");
            var     emailSender     = new EmailSender(emailDataHolder);

            var executor = new Executor(priceCalculator, emailSender);

            executor.Execute();
        }
    }
}
