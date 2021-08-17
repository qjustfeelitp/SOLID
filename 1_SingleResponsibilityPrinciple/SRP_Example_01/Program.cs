using System.Linq;

namespace SRP_Example_01
{
    /// <summary>
    /// What is wrong with this code?
    /// </summary>
    internal static class Program
    {
        public static void Main(string[] args)
        {
            var executor = new Executor
            {
                EmailSubject   = "Order placed",
                EmailRecipient = "example@example.com"
            };

            executor.PriceList.AddRange(Enumerable.Repeat(5m, 100));

            executor.Execute();
        }
    }
}
