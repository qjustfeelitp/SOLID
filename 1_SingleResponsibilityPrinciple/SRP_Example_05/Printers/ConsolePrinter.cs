using System;

namespace SRP_Example_05.Printers
{
    internal class ConsolePrinter : IPrinter
    {
        void IPrinter.Print(string message)
        {
            Console.WriteLine(message);
        }
    }
}
