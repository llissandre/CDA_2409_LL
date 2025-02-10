
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


            b1Fermee = bouteille1.Fermer();
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

            bool b2Ouverte = bouteille2.Ouvrir();
            if (b2Ouverte == false)
            {
                Console.WriteLine("La bouteille 2 était déjà ouverte !");
            }
            else
            {
                Console.WriteLine("La bouteille 2 a été ouverte !");
            }

            b2Ouverte = bouteille2.Ouvrir();
            if (b2Ouverte == false)
            {
                Console.WriteLine("La bouteille 2 était déjà ouverte !");
            }
            else
            {
                Console.WriteLine("La bouteille 2 a été ouverte !");
            }

            bool b1Videe = bouteille1.Vider();
            if (b1Videe == false)
            {
                Console.WriteLine("La bouteille 1 n'a pas pu être vidée !");
            }
            else
            {
                Console.WriteLine("La bouteille 1 a été vidée !");
            }

            bool b2Videe = bouteille2.Vider();
            if (b2Videe == false)
            {
                Console.WriteLine("La bouteille 2 n'a pas pu être vidée !");
            }
            else
            {
                Console.WriteLine("La bouteille 2 a été vidée !");
            }

            bool b1Ouverte = bouteille1.Ouvrir();
            if (b1Ouverte == false)
            {
                Console.WriteLine("La bouteille 1 était déjà ouverte !");
            }
            else
            {
                Console.WriteLine("La bouteille 1 a été ouverte !");
            }

            b1Videe = bouteille1.Vider();
            if (b1Videe == false)
            {
                Console.WriteLine("La bouteille 1 n'a pas pu être vidée !");
            }
            else
            {
                Console.WriteLine("La bouteille 1 a été vidée !");
            }

            bool b4Ouverte = bouteille4.Ouvrir();
            if (b4Ouverte == false)
            {
                Console.WriteLine("La bouteille 4 était déjà ouverte !");
            }
            else
            {
                Console.WriteLine("La bouteille 4 a été ouverte !");
            }

            bool b4Videe = bouteille4.Vider();
            if (b4Videe == false)
            {
                Console.WriteLine("La bouteille 4 n'a pas pu être vidée !");
            }
            else
            {
                Console.WriteLine("La bouteille 4 a été vidée !");
            }

            bool b4Remplie = bouteille4.Remplir();
            if (b4Remplie == false)
            {
                Console.WriteLine("La bouteille 4 n'a pas pu être remplie !");
            }
            else
            {
                Console.WriteLine("La bouteille 4 a été remplie !");
            }

            bool b4VideeQt = bouteille4.Vider(0.5f);

            b4VideeQt = bouteille4.Vider(0.5f);
            if (b4VideeQt == false)
            {
                Console.WriteLine("La bouteille 4 n'a pas pu être vidée de la quantité indiquée!");
            }
            else
            {
                Console.WriteLine("La bouteille 4 a été vidée de la quantité indiquée!");
            }

            bool b4RemplieQt = bouteille4.Remplir(0.2f);
            if (b4RemplieQt == false)
            {
                Console.WriteLine("La bouteille 4 n'a pas pu être remplie de la quantité indiqué !");
            }
            else
            {
                Console.WriteLine("La bouteille 4 a été remplie de la quantité indiquée!");
            }

            b4VideeQt = bouteille4.Vider(1.7f);
            if (b4VideeQt == false)
            {
                Console.WriteLine("La bouteille 4 n'a pas pu être vidée de la quantité indiquée!");
            }
            else
            {
                Console.WriteLine($"La bouteille 4 a été vidée de la quantité indiquée !");
            }

            b4RemplieQt = bouteille4.Remplir(2.2f);
            if (b4RemplieQt == false)
            {
                Console.WriteLine("La bouteille 4 n'a pas pu être remplie de la quantité indiqué !");
            }
            else
            {
                Console.WriteLine("La bouteille 4 a été remplie de la quantité indiquée!");
            }

            b4RemplieQt = bouteille4.Remplir(2f);
            if (b4RemplieQt == false)
            {
                Console.WriteLine("La bouteille 4 n'a pas pu être remplie de la quantité indiqué !");
            }
            else
            {
                Console.WriteLine("La bouteille 4 a été remplie de la quantité indiquée!");
            }

            b4VideeQt = bouteille4.Vider(2.7f);
            if (b4VideeQt == false)
            {
                Console.WriteLine("La bouteille 4 n'a pas pu être vidée de la quantité indiquée!");
            }
            else
            {
                Console.WriteLine("La bouteille 4 a été vidée de la quantité indiquée!");
            }

            Console.WriteLine(bouteille1.ToString());
            Console.WriteLine(bouteille2.ToString());
            Console.WriteLine(bouteille3.ToString());
            Console.WriteLine(bouteille4.ToString());

        }
    }
}
