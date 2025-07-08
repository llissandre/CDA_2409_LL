int Entiers = 0;

//affiche sur la console : "Entrer un premier nombre entier:"
Console.Write("Entrez un nombre entier : ");
//récupère le premier entier donné par l'utilisateur et
//parse la chaine de caractères et le range dans la variable E1
int E1 = int.Parse(Console.ReadLine());

//affiche sur la console : "Rentrer un second nombre entier:"
Console.Write("\nEntrez un nombre entier : ");
//récupère le second entier donné par l'utilisateur et
//parse la chaine de caractères et le range dans la variable E2
int E2 = int.Parse(Console.ReadLine());

//conditions
if ((E1 > 0 && E2 > 0) ^ (E1 < 0 && E2 < 0))
{
    Entiers++;
}

//case pour savoir si le produit des deux entiers est positif ou négatif
switch (Entiers)
{
    case 1:
        Console.WriteLine("\nLe produit des deux entiers est positif");
        break;

    default:
        Console.WriteLine("\nLe produit des deux entiers est négatif");
        break;
}
// permet de laisser la fenêtre de la console ouverte
Console.ReadLine();