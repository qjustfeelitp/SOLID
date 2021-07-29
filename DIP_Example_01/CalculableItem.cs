using System;

namespace DIP_Example_01
{
    internal class CalculableItem
    {
        public Guid Id { get; }
        public decimal Price { get; }

        public CalculableItem(Guid id, decimal price)
        {
            this.Price = price;
            this.Id    = id;
        }
    }
}
