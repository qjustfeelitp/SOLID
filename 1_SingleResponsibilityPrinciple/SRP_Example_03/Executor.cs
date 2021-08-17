using System;

namespace SRP_Example_03
{
    internal class Executor
    {
        public PriceCalculator PriceCalculator { get; }
        public EmailSender EmailSender { get; }

        public Executor(PriceCalculator priceCalculator, EmailSender emailSender)
        {
            this.PriceCalculator = priceCalculator;
            this.EmailSender     = emailSender;
        }

        public void Execute()
        {
            Console.WriteLine("Execution begins");

            decimal price = this.PriceCalculator.CalculatePrice();
            this.PriceCalculator.PrintPrice(price);

            this.EmailSender.SendMail();

            Console.WriteLine("Execution ends");
        }
    }
}
