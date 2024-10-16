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

using System.Globalization;
using System.Threading.Channels;


namespace Exercice_Collections
{
    internal class Program
    {
        static int yearBirth;
        static int monthBirth;
        static int dayBirth;
        static int yearNow;
        static int monthNow;
        static int dayNow;
        static int ageAn;
        static int ageMois;
        static int iterateur;
        static DateTime now = default;
        static DateTime date;
        static string saisie;
        static string name;
        static string metierOuCouleurPreferee;
        static bool majeur;
        static bool vrai;
        static string[] tabDates;

        static string saisirUnNomEtUnPrenom(string phrase)
        {
            vrai = false;

            do
            {
                Console.Write("Saisir un nom et un prenom : ");
                saisie = Console.ReadLine() ?? "";
                if (saisie != "")
                {
                    vrai = true;
                }
            }
            while (!vrai);

            return saisie;
        }

        static string saisirLeMetier(string phrase)
        {
            vrai = false;

            do
            {
                Console.Write("Saisir votre métier : ");
                saisie = Console.ReadLine() ?? "";
                if (saisie != "")
                {
                    vrai = true;
                }
            }
            while (!vrai);

            return saisie;
        }

        static string saisirLaCouleurPreferee(string phrase)
        {
            vrai = false;

            do
            {
                Console.Write("Saisir votre couleur préférée : ");
                saisie = Console.ReadLine() ?? "";
                if (saisie != "")
                {
                    vrai = true;
                }
            }
            while (!vrai);

            return saisie;
        }

        static bool ajoutUnAutreUtilisateur(char touch)
        {
            Console.Write("Voulez-vous ajouter une autre personne (N/0) ?");

            touch = Console.ReadKey(true).KeyChar;
            if (touch == 'o' || touch == 'O')
            {
                return true;
            }
            return false;
        }

        static bool estMajeur(DateTime date)
        {
            yearBirth = date.Year;
            monthBirth = date.Month;
            dayBirth = date.Day;
            now = DateTime.Now;
            yearNow = now.Year;
            monthNow = now.Month;
            dayNow = now.Day;

            ageAn = yearNow - yearBirth;

            if ((monthBirth > monthNow) || (monthBirth == monthNow && dayBirth > dayNow))
            {
                ageAn--;
            }

            if (ageAn >= 18)
            {
                return true;
            }
            return false;
        }

        static int sonAge(DateTime date)
        {
            yearBirth = date.Year;
            monthBirth = date.Month;
            dayBirth = date.Day;
            now = DateTime.Now;
            yearNow = now.Year;
            monthNow = now.Month;
            dayNow = now.Day;

            ageAn = yearNow - yearBirth;

            if ((monthBirth > monthNow) || (monthBirth == monthNow && dayBirth > dayNow))
            {
                ageAn--;
            }
            return ageAn;
        }

        static int sonAgeMois(DateTime date)
        {
            monthBirth = date.Month;
            dayBirth = date.Day;
            now = DateTime.Now;
            monthNow = now.Month;
            dayNow = now.Day;

            ageMois = monthNow - monthBirth;

            if (monthNow < monthBirth)
            {
                ageMois--;
            }
            return ageMois;
        }

        static DateTime saisirUneDateDeNaissance(string phrase)
        {
            now = DateTime.Now;

            do
            {
                Console.Write("Saisir une date de naissance (dd/mm/aaaa) : ");

                saisie = Console.ReadLine() ?? "";
                vrai = DateTime.TryParse(saisie, out date);
                // Pour imposer le format de la date
                //vrai = DateTime.TryParseExact(saisie, "dd MM yyyy", 
                //CultureInfo.InvariantCulture, DateTimeStyles.None, out //date//);

                tabDates = saisie.Split(' ', '/', '-');

                if (!vrai || tabDates.Length < 3)
                {
                    Console.WriteLine();
                    Console.WriteLine("La date fournie n'est pas dans un format valide!");
                    Console.WriteLine();
                }
            }
            while (!vrai || date > now || tabDates.Length < 3);

            return date;
        }

        static void Main(string[] args)
        {

            int ageAn;
            int ageMois;
            bool continuer;
            DateTime formatDate;
            string dateAffichee;
            bool majeur;
            string metierOuCouleurPreferee;
            string name;
            DateTime now = new DateTime();
            string[] user;
            List<string[]> users = new();
            //users = new List<string[]>();

            do
            {
                user = new string[3];

                now = DateTime.Now;

                name = saisirUnNomEtUnPrenom("");
                user[0] = name;

                formatDate = saisirUneDateDeNaissance("");

                dateAffichee = formatDate.ToLongDateString();

                majeur = estMajeur(formatDate);
                ageAn = sonAge(formatDate);
                ageMois = sonAgeMois(formatDate);

                if (ageAn == 0)
                {
                    user[1] = $"{dateAffichee}  ( {ageMois} mois )";
                }
                else
                {
                    user[1] = $"{dateAffichee}  ( {ageAn} ans )";
                }

                if (majeur)
                {
                    metierOuCouleurPreferee = saisirLeMetier("");
                    Console.WriteLine();
                }
                else
                {
                    metierOuCouleurPreferee = saisirLaCouleurPreferee("");
                    Console.WriteLine();
                }
                user[2] = metierOuCouleurPreferee;

                users.Add(user);

                continuer = ajoutUnAutreUtilisateur(' ');

                Console.WriteLine();
                Console.WriteLine();
            }
            while (continuer);

            foreach (string[] _user in users)
            {
                iterateur = 0;
                foreach (string u in _user)
                {
                    Console.Write(u);

                    if (iterateur < _user.Length - 1)
                    {
                        Console.Write(" - ");
                        iterateur++;
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
