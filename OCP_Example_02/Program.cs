using System;
using System.Linq;

namespace OCP_Example_02
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            foreach (var documentType in typeof(IDocument).Assembly.ExportedTypes.Where(x => typeof(IDocument).IsAssignableFrom(x) && !x.IsAbstract))
            {
                var document = (IDocument) Activator.CreateInstance(documentType, Enumerable.Repeat(10m, 10), 10m);

                Console.WriteLine($"Price for {documentType.Name} is {document?.Price}");
            }
        }
    }
}
