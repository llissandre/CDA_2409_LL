int Entier = 0;

//affiche sur la console : "Entrer un premier
//nombre entier:"
Console.Write("Entrez un nombre entier : ");

//parse la chaine de caractère "E" en un entier "Entier"
int E = int.Parse(Console.ReadLine());

if (E > 0)
{
    Entier++;
}

if (E < 0)
{
    Entier--;
}
//comparaisons
switch (Entier)
{
    //l'entier est-il positif ?
    case +1:
        Console.WriteLine("L'entier est positif");
        break;

    //l'entier est-il négatif ?
    case -1:
        Console.WriteLine("L'entier est négatif");
        break;

    //cas par défaut
    //l'entier est donc nul
    default:
        Console.WriteLine("L'entier est null");
        break;
}
// permet de laisser la fenêtre de la console ouverte
Console.ReadLine();