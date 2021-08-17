using System;
using System.Collections.Generic;
using System.Linq;

namespace OCP_Example_03
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            var documentCalculatorTypeByDocumentTypeDictionary = new Dictionary<Type, Type> // fake ioc
            {
                { typeof(Invoice), typeof(InvoiceCalculator) },
                { typeof(ReceivedOrder), typeof(ReceivedOrderCalculator) },
                { typeof(IssueSlip), typeof(IssueSlipCalculator) }
            };

            foreach (var documentType in typeof(IDocument).Assembly.ExportedTypes.Where(x => typeof(IDocument).IsAssignableFrom(x) && !x.IsAbstract))
            {
                var document = (IDocument) Activator.CreateInstance(documentType, Enumerable.Repeat(10m, 10), 10m);

                var documentCalculatorType = documentCalculatorTypeByDocumentTypeDictionary[documentType];

                var documentCalculator = (IDocumentCalculator) Activator.CreateInstance(documentCalculatorType);

                documentCalculator?.CalculatePrice(document);

                Console.WriteLine($"Price for {documentType.Name} is {document?.Price}");
            }
        }
    }
}
