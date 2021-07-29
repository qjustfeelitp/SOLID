using System;

using SRP_Example_05.Printers;

namespace SRP_Example_05.ExceptionHandlers
{
    internal class ExceptionHandler : IExceptionHandler
    {
        public IPrinter Printer { get; }

        public ExceptionHandler(IPrinter printer)
        {
            this.Printer = printer;
        }

        void IExceptionHandler.Handle(Exception exception)
        {
            this.Printer.Print(exception?.Message ?? "Something went wrong.");
        }
    }
}
