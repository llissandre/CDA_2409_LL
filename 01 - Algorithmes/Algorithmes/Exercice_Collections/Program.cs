﻿//Au démarrage, il n'y a aucun utilisateur enregistré.

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

        static void Main(string[] args)
        {
            int yearBirth;
            int monthBirth;
            int dayBirth;
            int yearNow;
            int monthNow;
            int dayNow;
            int ageAn;
            int ageMois;
            int iterateur;
            DateTime now = default;
            DateTime date;
            string dateAffichee;
            string name;
            string metierOuCouleurPreferee;
            string[] user;
            string saisie;
            List<string[]> users;
            bool majeur;
            bool vrai;
            bool ajout;

            string saisirUnNomEtUnPrenom(string phrase)
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

            string saisirVotreMetier(string phrase)
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

            string saisirVotreCouleurPreferee(string phrase)
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

            bool ajoutUtilisateur(char touch)
            {
                Console.Write("Voulez-vous ajouter une autre personne (N/0) ?");

                touch = Console.ReadKey(true).KeyChar;
                if (touch == 'o' || touch == 'O')
                {
                    return true;
                }
                return false;
            }

            bool estMajeur(DateTime date)
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

            int sonAge(DateTime date)
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

            int sonAgeMois(DateTime date)
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

            DateTime saisirUneDateDeNaissance(string phrase)
            {
                now = DateTime.Now;
                DateTime date;

                do
                {
                    Console.Write("Saisir une date de naissance (dd/mm/aaaa) : ");

                    saisie = Console.ReadLine() ?? "";
                    vrai = DateTime.TryParse(saisie, out date);
                    //vrai = DateTime.TryParseExact(saisie, "dd MM yyyy", 
                    //CultureInfo.InvariantCulture, DateTimeStyles.None, out //date//);

                    if (!vrai)
                    {
                        Console.WriteLine();
                        Console.WriteLine("La date fournie n'est pas dans un format valide!");
                        Console.WriteLine();
                    }
                }
                while (!vrai || date > now);

                return date;
            }

            users = new List<string[]>();

            do
            {
                user = new string[3];

                now = DateTime.Now;

                name = saisirUnNomEtUnPrenom("");
                user[0] = name;

                date = saisirUneDateDeNaissance("");

                dateAffichee = date.ToLongDateString();

                majeur = estMajeur(date);
                ageAn = sonAge(date);
                ageMois = sonAgeMois(date);

                if (ageAn == 0)
                {
                    user[1] = $"{dateAffichee}  ({ageMois} mois)";
                }
                else
                {
                    user[1] = $"{dateAffichee}  ({ageAn} ans)";
                }

                if (majeur)
                {
                    metierOuCouleurPreferee = saisirVotreMetier("");
                    Console.WriteLine();
                }
                else
                {
                    metierOuCouleurPreferee = saisirVotreCouleurPreferee("");
                    Console.WriteLine();
                }
                user[2] = metierOuCouleurPreferee;

                users.Add(user);

                ajout = ajoutUtilisateur(' ');

                Console.WriteLine();
                Console.WriteLine();
            }
            while (ajout);

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
