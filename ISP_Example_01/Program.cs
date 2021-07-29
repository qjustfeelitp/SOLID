using System;
using System.Linq;

namespace ISP_Example_01
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            foreach (var duckType in typeof(IDuck).Assembly.ExportedTypes.Where(x => typeof(IDuck).IsAssignableFrom(x) && !x.IsAbstract))
            {
                var duck = (IDuck) Activator.CreateInstance(duckType);

                try
                {
                    duck?.Fly();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }

                try
                {
                    duck?.Swim();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }

                try
                {
                    duck?.Speak();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }
    }
}
