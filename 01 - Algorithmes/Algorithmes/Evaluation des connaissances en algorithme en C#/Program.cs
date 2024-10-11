// See https://aka.ms/new-console-template for more information

//Solutionnez la problématique suivante dans une application en mode « Console » dans un des langages suivants : 
//C#.

//Au CRM, chaque stagiaire et chaque membre du personnel dispose d’une carte à son nom. 
//Pour régler les consommations avec la carte, il est nécessaire de l’alimenter en €. (Principe de la « carte prépayée »). 
//Pour régler un repas au restaurant du CRM, la carte est vérifiée :
//-Les données de la carte correspondent-elle à une personne enregistrée ?
//-   Y’a-t-il suffisamment de fonds disponibles ?
//Si les contrôles sont validés, le prix du repas est soustrait de la somme disponible sur la carte.

//Votre travail consiste à développer l’algorithme de validation de la carte.

//Pour simuler le fonctionnement, l’algorithme sera programmé dans une application en mode ‘Console’. 
//-   Le tableau ‘utilisateurs’ contiendra 5 utilisateurs.
//-   Le prix du repas sera fixé à 4 €
//-   Il n’est pas possible d’être « à découvert »


using System.Text.RegularExpressions;
Console.OutputEncoding = System.Text.Encoding.UTF8;

string entrerLeNomDeLaPersonne(string name)
{
    Console.Write("Entrez le nom de la personne : ");
    return UpperCaseFirstChar(Console.ReadLine());
}

string entrerUnNomValide(string name)
{
    Console.Write("Entrez un nom valide : ");
    return UpperCaseFirstChar(Console.ReadLine());
}
string UpperCaseFirstChar(string text)
{
    return Regex.Replace(text, "^[a-z]", m => m.Value.ToUpper());
}

bool voulezVousManger(char touch)
{
    Console.Write("Voulez-vous manger ? N/O");
    Console.WriteLine();
    touch = Console.ReadKey(true).KeyChar;
    if (touch == 'o' || touch == 'O')
    {
        return true;
    }
    else
    {
        return false;
    }
}

bool voulezVousConnaitreLeSoldeDeVotreCarte(char touch)
{
    Console.Write("Voulez-vous connaitre le solde de votre carte ? N/O");
    Console.WriteLine();
    touch = Console.ReadKey(true).KeyChar;
    if (touch == 'o' || touch == 'O')
    {
        return true;
    }
    else
    {
        return false;
    }
}

bool voulezVousRechargerVotreCarte(char touch)
{
    Console.Write("Voulez-vous recharger votre carte ? N/O");
    Console.WriteLine();
    touch = Console.ReadKey(true).KeyChar;
    if (touch == 'o' || touch == 'O')
    {
        return true;
    }
    else
    {
        return false;
    }
}

int montantRechargerVotreCarte(string phrase)
{
    string saisie;
    bool vrai;
    int nb;

    do
    {
        Console.Write("Indiquez le montant que vous souhaitez ajouter au solde de votre carte : ");
        saisie = Console.ReadLine();

        vrai = int.TryParse(saisie, out nb);
    }
    while (!vrai);

    return nb;
}

Dictionary<string, int> utilisateurs = new Dictionary<string, int>();
utilisateurs.Add("Allan", 4);
utilisateurs.Add("Rémi", 18);
utilisateurs.Add("Karan", 0);
utilisateurs.Add("Lores", 6);
utilisateurs.Add("Lucas", 8);

int theSolde;
int montant;
int repas = 4;
bool isOk = true;
bool heEat = false;
bool connaitreTheSolde = false;
bool rechargerVotreCarte = false;

string utilisateur = entrerLeNomDeLaPersonne("");
do
{
    do
    {
        isOk = utilisateurs.Keys.Contains(utilisateur);

        if (!isOk)
        {
            Console.WriteLine();
            Console.WriteLine("L'utilisateur n'a pas été trouvé.");
            utilisateur = entrerUnNomValide("");
        }
        else
        {
            {
                theSolde = utilisateurs[utilisateur];
                Console.WriteLine();

                rechargerVotreCarte = voulezVousRechargerVotreCarte(' ');
                if (rechargerVotreCarte)
                {
                    montant = montantRechargerVotreCarte("");
                    theSolde += montant;
                    utilisateurs[utilisateur] = theSolde;
                    Console.WriteLine($"{utilisateur}, votre solde est maintenant de {theSolde} € !");
                }

                heEat = voulezVousManger(' ');
                if (heEat)
                {
                    if (theSolde >= repas)
                    {

                        Console.WriteLine("Vous avez suffisamment de fonds pour manger.");
                        theSolde -= repas;
                        utilisateurs[utilisateur] = theSolde;
                        Console.WriteLine($"Le nouveau solde de votre carte est de : {theSolde} €.");
                        Console.WriteLine();

                        rechargerVotreCarte = voulezVousRechargerVotreCarte(' ');
                        if (rechargerVotreCarte)
                        {
                            montant = montantRechargerVotreCarte("");
                            theSolde += montant;
                            utilisateurs[utilisateur] = theSolde;
                            Console.WriteLine($"{utilisateur}, votre solde est maintenant de {theSolde} € !");
                        }
                    }
                    else
                    {
                        do
                        {
                            Console.WriteLine("Vous n'avez pas suffisamment de fonds pour manger, il n'est pas possible d'avoir un solde négatif. ");
                            rechargerVotreCarte = voulezVousRechargerVotreCarte(' ');
                            if (rechargerVotreCarte)
                            {
                                montant = montantRechargerVotreCarte("");
                                theSolde += montant;
                                utilisateurs[utilisateur] = theSolde;
                                Console.WriteLine($"{utilisateur}, votre solde est maintenant de {theSolde} € !");

                            }
                        } while (theSolde <= 0);
                    }
                }
            }

            connaitreTheSolde = voulezVousConnaitreLeSoldeDeVotreCarte(' ');
            if (connaitreTheSolde)
            {
                Console.WriteLine($"{utilisateur}, il te reste {theSolde} € sur ta carte !");
            }

            Console.WriteLine("Fin boucle");
        }
    }
    while (!isOk);
}
while (Console.ReadKey().Key != ConsoleKey.O);