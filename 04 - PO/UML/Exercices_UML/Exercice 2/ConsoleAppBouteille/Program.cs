
using ClassLibraryExercices;

namespace ConsoleAppBouteille
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //constructeur par defaut
            Bouteille bouteille1 = new Bouteille();

            // On nomme "argument" ce qui est entre les parenthèses dans un constructeur classique

            // Constructeur classique
            Bouteille bouteille2 = new Bouteille(3, 1, true);

            //constructeur hybride classique defaut
            Bouteille bouteille3 = new Bouteille(2, 2);
            bouteille3.GetHashCode();

            // Constructeur par clonage
            Bouteille bouteille4 = new Bouteille(bouteille3);
            bouteille4.GetHashCode();

            bool b1Fermee = bouteille1.Fermer();
            if (b1Fermee == false)
            {
                Console.WriteLine("La bouteille 1 était déjà fermée !");
            }
            else
            {
                Console.WriteLine("La bouteille 1 a été fermée !");
            }

            bool b2Fermee = bouteille2.Fermer();
            if (b2Fermee == false)
            {
                Console.WriteLine("La bouteille 2 était déjà fermée !");
            }
            else
            {
                Console.WriteLine("La bouteille 2 a été fermée !");
            }

            bool b2Ouverte = bouteille1.Ouvrir();
            if (b2Ouverte == false)
            {
                Console.WriteLine("La bouteille 2 était déjà ouverte !");
            }
            else
            {
                Console.WriteLine("La bouteille 2 a été ouverte !");
            }

            bool b2ReOuverte = bouteille2.Ouvrir();
            if (b2ReOuverte == false)
            {
                Console.WriteLine("La bouteille 2 était déjà ouverte !");
            }
            else
            {
                Console.WriteLine("La bouteille 2 a été ouverte !");
            }

            bool b1videe = bouteille1.Vider();
            bool b1Ouverte = bouteille1.Ouvrir();
            if (b1Ouverte == false)
            {
                Console.WriteLine("La bouteille 1 était déjà ouverte !");
            }
            else
            {
                Console.WriteLine("La bouteille 1 a été ouverte !");
            }
            bool b1revidee = bouteille1.Vider();

        }
    }
}
