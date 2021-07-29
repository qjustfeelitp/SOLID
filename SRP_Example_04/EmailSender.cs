using System;
using System.Net.Mail;

namespace SRP_Example_04
{
    internal class EmailSender
    {
        public void SendMail(EmailDataHolder emailDataHolder)
        {
            var emailMessageFactory = new EmailMessageFactory();

            var       mailMessage = emailMessageFactory.CreateMailMessage(emailDataHolder);
            using var smtpClient  = new SmtpClient();

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
