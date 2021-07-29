namespace OCP_Example_02
{
    internal class IssueSlipCalculator : DocumentCalculator
    {
        /// <inheritdoc />
        public override decimal CalculatePrice(IDocument document)
        {
            return document.Vat;
        }
    }
}
