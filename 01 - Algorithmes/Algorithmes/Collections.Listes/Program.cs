
/* Au démarrage, il n'y a aucun utilisateur enregistré.

1. Le programme demande à l'utilisateur de saisir un nom et un prénom.
    - L'utilisateur saisit un nom et un prénom

2. Lorsque toutes les informations sont saisies
	- Le programme enregistre l'utilisateur

3. Le programme demande à l'utilisateur s'il souhaite ajouter une autre personne.
	- Si oui
		- Retour à l'étape 1 (saisir nom et prénom)
	- Si non
		- Afficher tous les utilisateurs enregistrés
 
4. Le programme se termine
*/

namespace Collections.Listes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enregistrement de nouveaux utilisateurs");

            string[] utilisateurs;
            string[] tableauTemporaire;
            string saisieUtilisateur;
            char saisieOuiNon;

            utilisateurs = new string[] { };

            do
            {
                Console.Write($"{Environment.NewLine}Saisissez votre nom et votre prénom : ");
                saisieUtilisateur = Console.ReadLine() ?? "";

                tableauTemporaire = utilisateurs;
                utilisateurs = new string[utilisateurs.Length + 1];
                tableauTemporaire.CopyTo(utilisateurs, 0);

                utilisateurs[utilisateurs.Length - 1] = saisieUtilisateur;

                Console.WriteLine($"{Environment.NewLine}Souhaitez-vous ajouter un utilisateur ? N/O");
                saisieOuiNon = Console.ReadKey().KeyChar;
                Console.WriteLine("");
            }
            while (saisieOuiNon == 'o' || saisieOuiNon == 'O');
        }
    }
}

