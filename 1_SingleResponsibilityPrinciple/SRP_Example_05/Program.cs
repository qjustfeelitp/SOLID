using SRP_Example_05.Emails;
using SRP_Example_05.ExceptionHandlers;
using SRP_Example_05.Prices;
using SRP_Example_05.Printers;

namespace SRP_Example_05
{
    /// <summary>
    /// Is there anything wrong with this code?
    /// </summary>
    internal static class Program
    {
        public static void Main(string[] args)
        {
            var consolePrinter = new ConsolePrinter();
            var executor = new Executor(new PriceCalculator(),
                                        new PricePrinter(consolePrinter),
                                        new EmailSender(new EmailMessageFactory(), new ExceptionHandler(consolePrinter)),
                                        consolePrinter);

            executor.Execute();
        }
    }
}
