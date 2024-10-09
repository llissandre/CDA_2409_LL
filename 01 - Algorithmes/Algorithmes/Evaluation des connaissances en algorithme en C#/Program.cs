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


string entrerLeNomDeLaPersonne(string Phrase)
{
    Console.Write("Entrez le nom de la personne : ");
    return Console.ReadLine().ToLower();
}

string entrerUnNomValide(string Phrase)
{
    Console.Write("Entrez un nom valide : ");
    return Console.ReadLine().ToLower();
}

string voulezVousSortir(string Phrase)
{
    Console.Write("Voulez-vous sortir ?");
    return Console.ReadLine().ToLower();
}

string voulezVousManger(string Phrase)
{
    Console.Write("Voulez-vous manger ?");
    return Console.ReadLine().ToLower();
}


Dictionary<string, int> utilisateurs = new Dictionary<string, int>();
utilisateurs.Add("Allan", 4);
utilisateurs.Add("Rémi", 18);
utilisateurs.Add("Karan", 0);
utilisateurs.Add("Lores", 6);
utilisateurs.Add("Lucas", 8);

int solde;
int repas = 4;
bool isOk = true;
bool goOut = false;

string utilisateur = entrerLeNomDeLaPersonne("");

do
{
    utilisateur = entrerUnNomValide("");

    isOk = utilisateurs.Keys.Contains(utilisateur);

    if (!isOk)
    {
        Console.WriteLine("L'utlisateur n'a pas été trouvé.");
        Console.WriteLine("Il faut entrer un nom valide :");
    }
    else
    {
        {
            solde = utilisateurs[utilisateur];

            if (solde >= 4)
            {
                Console.WriteLine("Vous avez suffisamment de fonds pour manger.");
                solde -= 4;
                utilisateurs[utilisateur] = solde;
                Console.WriteLine($"Le nouveau solde de votre carte est de : {solde} euros.");
            }
            else
            {
                Console.WriteLine("Vous n'avez suffisamment de fonds pour manger, il n'est pas possible d'avoir un solde négatif. ");
            }
        }
    }

    bool goOut = voulezVousSortir("");
}
while (!goOut);