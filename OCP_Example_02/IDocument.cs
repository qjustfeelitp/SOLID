using System.Collections.Generic;

namespace OCP_Example_02
{
    internal interface IDocument
    {
        IEnumerable<decimal> ItemPrices { get; }
        decimal Price { get; }
        decimal Vat { get; }
    }
}
