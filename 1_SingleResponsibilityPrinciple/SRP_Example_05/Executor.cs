using System.Linq;

using SRP_Example_05.Emails;
using SRP_Example_05.Prices;
using SRP_Example_05.Printers;

namespace SRP_Example_05
{
    internal class Executor
    {
        private IPriceCalculator PriceCalculator { get; }
        private IPricePrinter PricePrinter { get; }
        private IEmailSender EmailSender { get; }
        private IPrinter Printer { get; }

        public Executor(IPriceCalculator priceCalculator, IPricePrinter pricePrinter, IEmailSender emailSender, IPrinter printer)
        {
            this.PriceCalculator = priceCalculator;
            this.PricePrinter    = pricePrinter;
            this.EmailSender     = emailSender;
            this.Printer         = printer;
        }

        public void Execute()
        {
            this.Printer.Print("Execution begins");

            var     priceHolder = new PriceHolder(Enumerable.Repeat(5m, 100));
            decimal price       = this.PriceCalculator.CalculatePrice(priceHolder);
            this.PricePrinter.PrintPrice(price);

            var emailDataHolder = new EmailDataHolder("example@example.com", "Order placed", $"Your order with value of {price:C} has been placed");
            this.EmailSender.SendMail(emailDataHolder);

            this.Printer.Print("Execution ends");
        }
    }
}
