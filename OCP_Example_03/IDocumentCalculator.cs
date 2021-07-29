namespace OCP_Example_03
{
    internal interface IDocumentCalculator<in TDocument> : IDocumentCalculator
        where TDocument : IDocument
    {
            void CalculatePrice(TDocument document);
        }

    internal interface IDocumentCalculator
    {
        void CalculatePrice(IDocument document); // hack for reflection
    }
}
