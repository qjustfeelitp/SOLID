using System.Collections.Generic;
using System.Linq;

namespace DIP_Example_01
{
    internal class ItemLoader
    {
        private DataAccess dataAccess;

        private DataAccess DataAccess
        {
            get { return this.dataAccess ??= new DataAccess(); }
        }

        public IEnumerable<CalculableItem> GetItemsWithPriceGreaterThan(int take, decimal upperRange)
        {
            return this.DataAccess.GetCalculableItems(take).Where(x => x.Price < upperRange);
        }
    }
}
