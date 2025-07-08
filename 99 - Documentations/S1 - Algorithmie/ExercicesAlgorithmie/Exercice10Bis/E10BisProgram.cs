//affiche sur la console : "Rentrer un premier nombre entier:"
Console.WriteLine("Rentrez un nombre entier :");
//récupère le premier entier donné par l'utilisateur et
//le range dans la variable E1
String E1 = Console.ReadLine();

//affiche sur la console : "Rentrer un second nombre entier:"
Console.WriteLine("\nRentrez un nombre entier :");
//récupère le second entier donné par l'utilisateur et
//le range dans la variable E2
String E2 = Console.ReadLine();

//parse la chaine de caractère "E1" en un entier "Entier1"
int Entier1 = int.Parse(E1);
//parse la chaine de caractère "E2" en un entier "Entier2"
int Entier2 = int.Parse(E2);

//si l'un des deux entiers est égal à zéro on ne doit pas effectuer
//le calcul
//alors
if (Entier1 > 0 && Entier2 > 0)
{
    Console.WriteLine("\nLe produit des deux entiers est positif");
}
else if (Entier1 < 0 && Entier2 < 0)
{
    Console.WriteLine("\nLe produit des deux entiers est positif");
}
//sinon
else
{
    Console.WriteLine("\nLe produit des deux entiers est négatif");
}

// permet de laisser la fenêtre de la console ouverte
Console.ReadLine();