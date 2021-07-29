using System;

namespace LSP_Example_01
{
    internal class EmailSender
    {
        public string Recipient { get; }
        public string Message { get; }

        public EmailSender(string recipient, string message)
        {
            this.Recipient = recipient;
            this.Message   = message;
        }

        public void SendMessage()
        {
            Console.WriteLine($"Message: {this.Message} {Environment.NewLine}"
                            + $"Sent to: {this.Recipient}");
        }
    }
}
