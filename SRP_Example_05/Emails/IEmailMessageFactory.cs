using System.Net.Mail;

namespace SRP_Example_05.Emails
{
    internal interface IEmailMessageFactory
    {
        MailMessage CreateMailMessage(EmailDataHolder emailDataHolder);
    }
}
