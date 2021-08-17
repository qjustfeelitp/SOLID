using System.Collections.Generic;
using System.Linq;

namespace DIP_Example_02
{
    internal class ItemLoader : IItemLoader
    {
        private IDataAccess DataAccessor { get; }

        public ItemLoader(IDataAccess dataAccessor)
        {
            this.DataAccessor = dataAccessor;
        }

        public IEnumerable<CalculableItem> GetItemsWithPriceGreaterThan(int take, decimal upperRange)
        {
            return this.DataAccessor.GetCalculableItems(take).Where(x => x.Price < upperRange);
        }
    }
}
