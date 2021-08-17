using System.Collections.Generic;

namespace DIP_Example_02
{
    internal interface IItemLoader
    {
        IEnumerable<CalculableItem> GetItemsWithPriceGreaterThan(int take, decimal upperRange);
    }
}
