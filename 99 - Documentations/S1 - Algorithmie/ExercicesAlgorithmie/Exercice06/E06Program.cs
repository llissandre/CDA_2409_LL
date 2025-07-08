
//affiche sur la console : "Rentrer un nombre entier:"
Console.WriteLine("Rentrez un nombre entier :");

//récupère l'entier donné par l'utilisateur et
//le range dans la variable N
String N = Console.ReadLine();

//parse la chaine de caractère "N" en un entier "Nombre"
int Nombre = int.Parse(N);

//vérifie si le nombre est pair
if (Nombre % 2 == 0) // comparer le modulo de Nombre par 2 avec 0
{
    //écrire pair si le nombre est pair
    Console.WriteLine("Pair");
}
else
{
    //écrire impair si le nombre est impaire
    Console.WriteLine("Impair");
}
// permet de laisser la fenêtre de la console ouverte
Console.ReadLine();