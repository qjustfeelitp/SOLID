using System.Net.Mail;

namespace SRP_Example_05.Emails
{
    internal class EmailMessageFactory : IEmailMessageFactory
    {
        MailMessage IEmailMessageFactory.CreateMailMessage(EmailDataHolder emailDataHolder)
        {
            return new("example@example.com", emailDataHolder.EmailRecipient, emailDataHolder.EmailSubject, emailDataHolder.EmailBody);
        }
    }
}
