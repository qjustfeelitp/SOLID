using System;

namespace ISP_Example_01
{
    internal class PictureDuck : IDuck
    {
        /// <inheritdoc />
        public void Fly()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void Swim()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void Speak()
        {
            throw new NotImplementedException();
        }
    }
}
