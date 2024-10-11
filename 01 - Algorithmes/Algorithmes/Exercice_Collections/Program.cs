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
            string saisirUnNomEtUnPrenom(string name, string prenom)
            {
                Console.Write("Saisir un nom et un prenom : ");
                return (Console.ReadLine());
            }

            DateTime saisirUneDateDeNaissance(DateTime date)
            {
                Console.Write("Saisir un nom et un prenom : ");
                return date;
            }




        }
    }
}
