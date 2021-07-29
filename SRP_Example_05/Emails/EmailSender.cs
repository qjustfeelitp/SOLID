using System;
using System.Net.Mail;

using SRP_Example_05.ExceptionHandlers;

namespace SRP_Example_05.Emails
{
    internal class EmailSender : IEmailSender
    {
        private IEmailMessageFactory Factory { get; }
        public IExceptionHandler ExceptionHandler { get; }

        public EmailSender(IEmailMessageFactory factory, IExceptionHandler exceptionHandler)
        {
            this.Factory          = factory;
            this.ExceptionHandler = exceptionHandler;
        }

        void IEmailSender.SendMail(EmailDataHolder emailDataHolder)
        {
            var mailMessage = this.Factory.CreateMailMessage(emailDataHolder);
            using var smtpClient =
                new SmtpClient(); // could be abstracted to receive generic email client, where concrete client is defined in code that consumes this, so that swapping email clients is easy (SendGrid, SmtpClient, MailKit ...)

            try
            {
                smtpClient.Send(mailMessage);
            }
            catch (Exception exception)
            {
                // Polly could be used with retry policy
                this.ExceptionHandler.Handle(exception);
            }
        }
    }
}
