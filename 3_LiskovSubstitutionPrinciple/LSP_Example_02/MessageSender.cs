using System;

namespace LSP_Example_02
{
    public abstract class MessageSender : IMessageSender
    {
        protected string Recipient { get; }
        protected string Message { get; }

        protected MessageSender(string recipient, string message)
        {
            this.Recipient = recipient;
            this.Message   = message;
        }

        void IMessageSender.SendMessage()
        {
            Console.WriteLine($"Message: {this.Message}"
                            + $"{Environment.NewLine}"
                            + $"Sent to: {this.Recipient}"
                            + $"{Environment.NewLine}"
                            + $"Sent from {GetType().Name}");
        }
    }
}
