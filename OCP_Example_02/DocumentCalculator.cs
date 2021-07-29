namespace OCP_Example_02
{
    internal abstract class DocumentCalculator : IDocumentCalculator
    {
        public abstract decimal CalculatePrice(IDocument document);
    }
}
