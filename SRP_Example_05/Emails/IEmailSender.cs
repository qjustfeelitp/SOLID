namespace SRP_Example_05.Emails
{
    internal interface IEmailSender
    {
        void SendMail(EmailDataHolder emailDataHolder);
    }
}
