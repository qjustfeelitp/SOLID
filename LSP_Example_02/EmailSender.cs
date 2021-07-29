namespace LSP_Example_02
{
    public class EmailSender : MessageSender
    {
        /// <inheritdoc />
        public EmailSender(string recipient, string message) : base(recipient, message)
        {
        }
    }
}
