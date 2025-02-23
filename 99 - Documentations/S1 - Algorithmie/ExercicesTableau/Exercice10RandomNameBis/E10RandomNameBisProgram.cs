//10.Random name(optionnel)
//On veut tirer au sort un nom parmi une liste de noms saisis par l'utilisateur.

//Première étape
//Il s'agit d'initialiser un tableau avec des noms saisis par l'utilisateur (maximum 12).
//Il ne doit pas y avoir de noms en double.
//Le programme recherchera si le nom saisi existe déjà dans le tableau.
//Si le nom n'existe pas déjà, il sera ajouté sinon il sera ignoré.

//Seconde étape
//Le tableau de noms étant initialisé, il s'agit maintenant de tirer au sort un nom.


//fonction pour demander que l'utilisateur entre un nom
String DemanderNom(String Phrase)
{
    Console.Write(Phrase);
    return Console.ReadLine();
}

Console.Write("Combien de noms souhaitez-vous entrer ? ");
int NbNom = int.Parse(Console.ReadLine());

//un tableau pour ranger les noms
string[] Noms = new string[NbNom];

//tirage au sort
Random Tirageausort = new Random();
//permet de générer un nom aléatoire
int Tiragenom = Tirageausort.Next(Noms.Length);

//pour saisir les noms
for (int Iterateur = 0; Iterateur < Noms.Length; Iterateur++)
{
    string Nom = DemanderNom("Entrez un nom : ");

    //Boucle tant que le nom est déjà entré
    while (Contient(Noms, Nom))
    {
        Nom = DemanderNom("Le nom est déjà présent.\nVeuillez entrez un nom qui n'est pas déjà présent : ");
    }
    Noms[Iterateur] = Nom;
}
Console.WriteLine();

//pour afficher les noms rentrés et leur positionnement
for (int Iterateur = 0; Iterateur < Noms.Length; Iterateur++)
{
    Console.Write($"L'élément {Iterateur + 1} du tableau est : " + Noms[Iterateur] + "\n");
}

//tirage au sort du Nom (noms donnés par l'utilisateur) tiré au sort
Console.Write($"\nLe nom tiré au sort est : {Noms[Tiragenom]} \n");

//fonction pour rechercher si le nom choisi a déjà été rentré
bool Contient(string[] Tableau, string Valeur)
{
    for (int Iterateur = 0; Iterateur < Tableau.Length; Iterateur++)
    {
        if (Tableau[Iterateur] == Valeur)
        {
            return true;
        }
    }
    return false;
}