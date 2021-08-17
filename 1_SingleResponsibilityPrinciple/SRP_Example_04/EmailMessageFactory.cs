using System.Net.Mail;

namespace SRP_Example_04
{
    internal class EmailMessageFactory
    {
        public MailMessage CreateMailMessage(EmailDataHolder emailDataHolder)
        {
            return new("example@example.com", emailDataHolder.EmailRecipient, emailDataHolder.EmailSubject, emailDataHolder.EmailBody);
        }
    }
}
