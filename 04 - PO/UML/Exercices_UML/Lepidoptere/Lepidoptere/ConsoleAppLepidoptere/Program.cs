using ClassLibraryLepidoptere;

namespace ConsoleAppLepidoptere
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lepidoptere lepi;
            lepi = new Lepidoptere("Bombyx");
            lepi.SeDeplacer();

            lepi.SeMetamorphoser();

            lepi.SeDeplacer();
           
        }
    }
}
