using System;

namespace ISP_Example_01
{
    internal class MallardDuck : IDuck
    {
        /// <inheritdoc />
        public void Fly()
        {
            Console.WriteLine("Flying");
        }

        /// <inheritdoc />
        public void Swim()
        {
            Console.WriteLine("Swimming");
        }

        /// <inheritdoc />
        public void Speak()
        {
            Console.WriteLine("Ga ga");
        }
    }
}
