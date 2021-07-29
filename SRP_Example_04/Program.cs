namespace SRP_Example_04
{
    /// <summary>
    /// What is wrong with this code?
    /// </summary>
    internal static class Program
    {
        public static void Main(string[] args)
        {
            var executor = new Executor(new PriceCalculator(), new PricePrinter(), new EmailSender());

            executor.Execute();
        }
    }
}
