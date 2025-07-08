int Note = 8;

//affiche sur la console : "Saisissez une note
Console.Write("Entrez une note : ");

//récupère le premier entier donné par l'utilisateur et
//le range dans la variable N
//parse la chaine de caractère "N" en un entier "Note"
int N = int.Parse(Console.ReadLine());

//comparaisons pour savoir si l'élève est admis
if (N >= 10)
{
    Note += 2;
}

if (N > 8 && N < 10)
{
    Note += 1;
}

//case pour savoir si l'élève est admis, en rattrapage ou dans l'état "échec"
switch (Note)
{
    //l'élève est admis
    case 10:
        Console.WriteLine("Admis");
        break;

    //l'élève est en rattrapage
    case 9:
        Console.WriteLine("Rattrapage");
        break;

    //par défaut les deux comparaison précédente étant fausses
    //écrire échec
    default:
        Console.WriteLine("Echec");
        break;

}
// permet de laisser la fenêtre de la console ouverte
Console.ReadLine();