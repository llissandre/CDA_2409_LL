//Au démarrage, il n'y a aucun utilisateur enregistré.

//## Déroulement du programme

//1. Le programme demande à l'utilisateur de saisir un nom et un prénom.
//      - L’utilisateur saisit un nom et un prénom.

//2. Le programme demande à l'utilisateur de saisir la date de naissance.
//      - L'utilisateur saisit la date de naissance.

//3. Le programme calcule l'âge de la personne en cours d'ajout.
//      - Si l’âge est supérieur ou égal à 18 (majeur)
//            - Le programme demande à l'utilisateur de saisir son métier.
//      - Si l’âge est inférieur à 18 (mineur)
//            - Le programme demande à l'utilisateur de saisir sa couleur préférée.

//4. Lorsque toutes les informations sont saisies
//      - Le programme enregistre l'utilisateur

//5. Le programme demande à l'utilisateur s'il souhaite ajouter une autre personne.
//      - Si oui
//            - Retour à l'étape 1 (saisir nom et prénom)
//      - Si non
//            - Afficher tous les utilisateurs enregistrés en respectant ce format :
//            -Nom Prénom - Date de naissance(âge) -Métier / Couleur préférée

//6. Le programme remercie l'utilisateur et se termine

namespace Exercice_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string saisirUnNomEtUnPrenom(string phrase)
            {
                Console.Write("Saisir un nom et un prenom : ");
                return Console.ReadLine() ?? "";
            }

            string saisirVotreMetier(string phrase)
            {
                Console.Write("Saisir votre métier : ");
                return Console.ReadLine() ?? "";
            }

            string saisirVotreCouleurPreferee(string phrase)
            {
                Console.Write("Saisir votre couleur préférée : ");
                return Console.ReadLine() ?? "";
            }

            bool calculAge(DateTime date)
            {
                int yearBirth;
                int monthBirth;
                int yearNow;
                int monthNow;
                int age;
                DateTime now;

                yearBirth = date.Year;
                monthBirth = date.Month;
                now = DateTime.Now;
                yearNow = now.Year;
                monthNow = now.Month;

                age = yearNow - yearBirth;
                if (monthBirth < monthNow)
                {
                    age--;
                }
                if (age >= 18)
                {
                    return true;
                }
                return false;
            }

            DateTime saisirUneDateDeNaissance(string phrase)
            {
                DateTime date;
                string saisie;
                bool vrai;

                do
                {
                    Console.Write("Saisir une date de naissance : dd-mm-aaaa");

                    saisie = Console.ReadLine() ?? "";
                    vrai = DateTime.TryParse(saisie, out date);
                }
                while (!vrai);

                return date;
            }

            DateTime now;
            DateTime date;
            string name;
            bool majeur;

            now = DateTime.Now;
            Console.WriteLine(now);
            Console.WriteLine(now.Year);

            name = saisirUnNomEtUnPrenom("");

            date = saisirUneDateDeNaissance("");

            majeur = calculAge(date);

            if (majeur)
            {
                Console.WriteLine(saisirVotreMetier(""));
            }
            else
            {
                Console.WriteLine(saisirVotreCouleurPreferee(""));
            }
        }
    }
}
