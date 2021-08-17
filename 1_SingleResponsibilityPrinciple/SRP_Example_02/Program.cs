using System.Linq;

namespace SRP_Example_02
{
    /// <summary>
    /// What is wrong with this code?
    /// </summary>
    internal static class Program
    {
        public static void Main(string[] args)
        {
            var executor = new Executor("example@example.com", "Order placed", Enumerable.Repeat(5m, 100));

            executor.Execute();
        }
    }
}
