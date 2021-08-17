namespace OCP_Example_03
{
    internal class IssueSlipCalculator : DocumentCalculator<IssueSlip>
    {
        /// <inheritdoc />
        public override void CalculatePrice(IssueSlip document)
        {
            document.Price = document.Vat;
        }
    }
}
