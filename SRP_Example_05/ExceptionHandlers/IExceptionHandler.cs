using System;

namespace SRP_Example_05.ExceptionHandlers
{
    internal interface IExceptionHandler
    {
        void Handle(Exception exception);
    }
}
