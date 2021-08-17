using System;
using System.Net.Mail;

namespace SRP_Example_03
{
    internal class EmailSender
    {
        public EmailDataHolder EmailDataHolder { get; }

        public EmailSender(EmailDataHolder emailDataHolder)
        {
            this.EmailDataHolder = emailDataHolder;
        }

        private MailMessage CreateMailMessage()
        {
            return new("example@example.com", this.EmailDataHolder.EmailRecipient, this.EmailDataHolder.EmailSubject, this.EmailDataHolder.EmailBody);
        }

        public void SendMail()
        {
            var       mailMessage = CreateMailMessage();
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
