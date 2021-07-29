namespace LSP_Example_01
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            const string recipient = "haha";
            const string message   = "ahoj";

            var smsSender = new SmsSender(recipient, message);
            smsSender.SendMessage();

            var emailSender = new EmailSender(recipient, message);
            emailSender.SendMessage();

            var teamsSender = new TeamsSender(recipient, message);
            teamsSender.SendMessage();
        }
    }
}
