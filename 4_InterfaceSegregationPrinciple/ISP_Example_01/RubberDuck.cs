using System;

namespace ISP_Example_01
{
    internal class RubberDuck : IDuck
    {
        /// <inheritdoc />
        public void Fly()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void Swim()
        {
            Console.WriteLine("Floating");
        }

        /// <inheritdoc />
        public void Speak()
        {
            Console.WriteLine("Sqeek");
        }
    }
}
