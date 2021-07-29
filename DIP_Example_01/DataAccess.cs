using System;
using System.Collections.Generic;

namespace DIP_Example_01
{
    internal class DataAccess
    {
        public IEnumerable<CalculableItem> GetCalculableItems(int take)
        {
            var random = new Random();
            for (int i = 0; i < take; i++)
            {
                yield return new CalculableItem(Guid.NewGuid(), random.Next(default, int.MaxValue / 100));
            }
        }
    }
}
