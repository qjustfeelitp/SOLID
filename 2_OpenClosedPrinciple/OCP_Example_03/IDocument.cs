using System.Collections.Generic;

namespace OCP_Example_03
{
    internal interface IDocument
    {
        IEnumerable<decimal> ItemPrices { get; }
        decimal Price { get; }
        decimal Vat { get; }
    }
}
