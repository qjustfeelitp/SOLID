using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;

namespace SRP_Example_02
{
    internal class Executor
    {
        private string EmailRecipient { get; }
        private string EmailSubject { get; }
        private string EmailBody { get; set; }

        private List<decimal> PriceList { get; }

        public Executor(string emailRecipient, string emailSubject, IEnumerable<decimal> prices)
        {
            this.EmailRecipient = emailRecipient;
            this.EmailSubject   = emailSubject;
            this.PriceList      = new List<decimal>(prices);
        }

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
