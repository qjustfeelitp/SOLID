using System;
using System.Linq;

namespace SRP_Example_04
{
    internal class Executor
    {
        public PriceCalculator PriceCalculator { get; }
        public PricePrinter PricePrinter { get; }
        public EmailSender EmailSender { get; }

        public Executor(PriceCalculator priceCalculator, PricePrinter pricePrinter, EmailSender emailSender)
        {
            this.PriceCalculator = priceCalculator;
            this.PricePrinter    = pricePrinter;
            this.EmailSender     = emailSender;
        }

        public void Execute()
        {
            Console.WriteLine("Execution begins");

            var     priceHolder = new PriceHolder(Enumerable.Repeat(5m, 100));
            decimal price       = this.PriceCalculator.CalculatePrice(priceHolder);
            this.PricePrinter.PrintPrice(price);

            var emailDataHolder = new EmailDataHolder("example@example.com", "Order placed", $"Your order with value of {price:C} has been placed");
            this.EmailSender.SendMail(emailDataHolder);

            Console.WriteLine("Execution ends");
        }
    }
}
