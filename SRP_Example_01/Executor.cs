using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;

namespace SRP_Example_01
{
    internal class Executor
    {
        public string EmailRecipient { get; set; }
        public string EmailSubject { get; set; }
        private string EmailBody { get; set; }

        public List<decimal> PriceList { get; set; } = new();

        public void Execute()
        {
            Console.WriteLine("Execution begins");

            decimal price = CalculatePrice();
            PrintPrice(price);

            this.EmailBody = $"Your order with value of {price:C} has been placed";

            var mailMessage = CreateMailMessage();
            SendMail(mailMessage);

            Console.WriteLine("Execution ends");
        }

        private decimal CalculatePrice()
        {
            return this.PriceList.Sum();
        }

        private void PrintPrice(decimal price)
        {
            Console.WriteLine($"Total amount: {price:C}");
        }

        private MailMessage CreateMailMessage()
        {
            return new("example@example.com", this.EmailRecipient, this.EmailSubject, this.EmailBody);
        }

        private void SendMail(MailMessage mailMessage)
        {
            using var smtpClient = new SmtpClient();

            try
            {
                smtpClient.Send(mailMessage);
            }
            catch (Exception)
            {
                // ignore
            }
        }
    }
}
