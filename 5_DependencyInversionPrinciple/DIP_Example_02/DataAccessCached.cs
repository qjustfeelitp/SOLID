using System.Collections.Generic;
using System.Linq;

namespace DIP_Example_02
{
    internal class DataAccessCached : IDataAccess
    {
        public IDataAccess DataAccessNotCached { get; }

        private List<CalculableItem> Cached { get; } = new();

        public DataAccessCached(IDataAccess dataAccessNotCached)
        {
            this.DataAccessNotCached = dataAccessNotCached;
        }

        /// <inheritdoc />
        public IEnumerable<CalculableItem> GetCalculableItems(int take)
        {
            if (this.Cached.Count > 0)
            {
                return this.Cached.Take(take);
            }

            this.Cached.AddRange(this.DataAccessNotCached.GetCalculableItems(take));

            return this.Cached;
        }
    }
}
