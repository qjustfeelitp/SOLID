using System.Collections.Generic;

namespace DIP_Example_02
{
    internal interface IDataAccess
    {
        IEnumerable<CalculableItem> GetCalculableItems(int take);
    }
}
