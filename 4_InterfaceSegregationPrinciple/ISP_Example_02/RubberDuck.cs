using System;

namespace ISP_Example_02
{
    internal class RubberDuck : ISwimmingBehaviour, ISpeakingBehaviour, IDisplayBehaviour
    {
        /// <inheritdoc />
        public void Swim()
        {
            Console.WriteLine("Floating");
        }

        /// <inheritdoc />
        public void Speak()
        {
            Console.WriteLine("Squeak");
        }

        /// <inheritdoc />
        public void Display()
        {
            Console.WriteLine("I'm a yellow rubber duck.");
        }
    }
}
