// See https://aka.ms/new-console-template for more information




using _28._3;
internal class Program
{
    private static void Main(string[] args)
    { 
            Agenzia agenzia = new Agenzia();
            List<Immobile> results = agenzia.SearchImmobili();
            foreach (Immobile i in results)
            {
                Console.WriteLine(i.ToString());


            }
    }
}