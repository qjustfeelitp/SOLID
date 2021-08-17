namespace LSP_Example_02
{
    public class SmsSender : MessageSender
    {
        /// <inheritdoc />
        public SmsSender(string recipient, string message) : base(recipient, message)
        {
        }
    }
}
