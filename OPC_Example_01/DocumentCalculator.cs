using System;
using System.Linq;

namespace OPC_Example_01
{
    internal class DocumentCalculator
    {
        public void CalculatePrice(Document document)
        {
            switch (document.DocumentType)
            {
                case DocumentType.Invoice:
                    CalculateInvoicePrice(document);
                    break;

                case DocumentType.ReceivedOrder:
                    CalculateReceivedOrderPrice(document);
                    break;

                case DocumentType.IssueSlip:
                    CalculateIssueSlipPrice(document);
                    break;

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private static void CalculateInvoicePrice(Document document)
        {
            document.Price = document.ItemPrices.Sum() + document.Vat;
        }

        private static void CalculateReceivedOrderPrice(Document document)
        {
            document.Price = document.ItemPrices.Max() - document.Vat;
        }

        private static void CalculateIssueSlipPrice(Document document)
        {
            document.Price = document.Vat;
        }
    }
}
