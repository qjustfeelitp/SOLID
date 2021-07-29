namespace LSP_Example_02
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            const string recipient = "haha";
            const string message   = "ahoj";

            IMessageSender smsSender = new SmsSender(recipient, message);
            smsSender.SendMessage();

            IMessageSender emailSender = new EmailSender(recipient, message);
            emailSender.SendMessage();

            IMessageSender teamsSender = new TeamsSender(recipient, message);
            teamsSender.SendMessage();
        }
    }
}
