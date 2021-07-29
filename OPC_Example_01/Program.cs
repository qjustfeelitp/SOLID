using System;
using System.Linq;

namespace OPC_Example_01
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            var documentCalculator = new DocumentCalculator();

            foreach (var documentType in Enum.GetValues<DocumentType>())
            {
                var document = new Document(documentType, Enumerable.Repeat(10m, 10), 10m);

                documentCalculator.CalculatePrice(document);

                Console.WriteLine($"Price for {document.DocumentType:G} is {document.Price}");
            }
        }
    }
}
