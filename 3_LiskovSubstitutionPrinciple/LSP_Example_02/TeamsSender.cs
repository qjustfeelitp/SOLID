namespace LSP_Example_02
{
    public class TeamsSender : MessageSender
    {
        /// <inheritdoc />
        public TeamsSender(string recipient, string message) : base(recipient, message)
        {
        }
    }
}
