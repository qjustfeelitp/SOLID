namespace OCP_Example_03
{
    internal abstract class DocumentCalculator<TDocument> : IDocumentCalculator<TDocument>
        where TDocument : IDocument
    {
        public abstract void CalculatePrice(TDocument document);

        /// <inheritdoc />
        public void CalculatePrice(IDocument document) // hack for reflection
        {
            CalculatePrice((TDocument) document);
        }
    }
}
