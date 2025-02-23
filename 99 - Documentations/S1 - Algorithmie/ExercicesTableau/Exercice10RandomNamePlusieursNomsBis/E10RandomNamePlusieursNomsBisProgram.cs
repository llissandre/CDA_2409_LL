//10.Random name(optionnel)
//On veut tirer au sort un nom parmi une liste de noms saisis par l'utilisateur.

//Première étape
//Il s'agit d'initialiser un tableau avec des noms saisis par l'utilisateur (maximum 12).
//Il ne doit pas y avoir de noms en double.
//Le programme recherchera si le nom saisi existe déjà dans le tableau.
//Si le nom n'existe pas déjà, il sera ajouté sinon il sera ignoré.

//Seconde étape
//Le tableau de noms étant initialisé, il s'agit maintenant de tirer au sort un nom.

//En bonus
//Possibilité de tirer au sort plusieurs noms, le nombre sera donné par l'utilisateur.
//Si un nom est tiré au sort une deuxième fois, le programme fera un nouveau tirage.



//fonction pour demander que l'utilisateur entre un nom
String DemanderNom(String Phrase)
{
    Console.Write(Phrase);
    return Console.ReadLine();
}

int DemanderNbDeTirageSouhaite(string Phrase)
{
    Console.Write(Phrase);
    int N = int.Parse(Console.ReadLine());

    return N;
}

Console.Write("Combien de noms souhaitez-vous entrer ? ");
int NbNomsTires = int.Parse(Console.ReadLine());

//un tableau pour ranger les noms
string[] Noms = new string[NbNomsTires];

//tirage au sort
Random Tirageausort = new Random();

//pour saisir les 12 noms
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

//affiche les noms rentrés et leur positionnement
for (int Iterateur = 0; Iterateur < Noms.Length; Iterateur++)
{
    Console.Write($"L'élément {Iterateur} du tableau est : " + Noms[Iterateur] + "\n");
}

//demande le nombre de tirage souhaités
int N = DemanderNbDeTirageSouhaite("\nCombien de tirages de tirage au sort souhaitez-vous effectuer ? ");
//création du tableau pour insérer les noms tirés au sort
string[] MotsTires = new string[N];

//boucle pour tirer au sort des noms en fct de N (qui défini le nb de tirage souhaité)
for (int Iterateur = 0; Iterateur < N; Iterateur++)
{
    Console.WriteLine();

    //permet de générer des noms aléatoires
    int Tiragenom = Tirageausort.Next(Noms.Length);
    //affiche le nom tiré au sort
    Console.Write($"Le nom tiré au sort est : {Noms[Tiragenom]}");

    while (Contient(MotsTires, Noms[Tiragenom]))
    {
        Tiragenom = Tirageausort.Next(Noms.Length);
        Console.Write($"Le nom tiré au sort est : {Noms[Tiragenom]}");
    }
}

Console.WriteLine();
Console.Write($"\nLe nombre de nom(s) tiré(s) au sort est : {N}\n");

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