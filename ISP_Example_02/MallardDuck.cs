using System;

namespace ISP_Example_02
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

        /// <inheritdoc />
        public void Display()
        {
            Console.WriteLine("I'm a mallard duck.");
        }
    }
}
