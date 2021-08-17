namespace SRP_Example_05.Emails
{
    internal class EmailDataHolder
    {
        public string EmailRecipient { get; }
        public string EmailSubject { get; }
        public string EmailBody { get; }

        public EmailDataHolder(string emailRecipient, string emailSubject, string emailBody)
        {
            this.EmailRecipient = emailRecipient;
            this.EmailSubject   = emailSubject;
            this.EmailBody      = emailBody;
        }
    }
}
