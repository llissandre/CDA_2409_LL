//affiche sur la console : "Rentrer un premier
//nombre entier:"
Console.WriteLine("Entrez un nombre entier :");
//récupère le premier entier donné par l'utilisateur et
//le range dans la variable E
String E = Console.ReadLine();

//parse la chaine de caractère "E" en un entier "Entier"
int Entier = int.Parse(E);

//comparaison pour savoir si l'entier est positif
if (Entier > 0)
{
    Console.WriteLine("L'entier est positif");
}

//comparaison pour savoir si l'entier est nul
else if (Entier == 0)
{
    Console.WriteLine("L'entier est null");
}

//les deux comparaison précédente étant fausses
//l'entier est donc négatif
else
{
    Console.WriteLine("L'entier est négatif");
}

// permet de laisser la fenêtre de la console ouverte
Console.ReadLine();