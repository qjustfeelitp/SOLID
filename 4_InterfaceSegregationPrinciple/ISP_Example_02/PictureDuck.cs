using System;

namespace ISP_Example_02
{
    internal class PictureDuck : IDisplayBehaviour
    {
        /// <inheritdoc />
        public void Display()
        {
            Console.WriteLine("I'm a picture duck.");
        }
    }
}
