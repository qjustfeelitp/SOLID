using SRP_Example_05.Printers;

namespace SRP_Example_05.Prices
{
    internal class PricePrinter : IPricePrinter
    {
        private IPrinter Printer { get; }

        public PricePrinter(IPrinter printer)
        {
            this.Printer = printer;
        }

        void IPricePrinter.PrintPrice(decimal price)
        {
            this.Printer.Print($"Total amount: {price:C}");
        }
    }
}
