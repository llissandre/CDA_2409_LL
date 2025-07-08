//affiche sur la console : "Rentrer un premier
//nombre entier:"
Console.WriteLine("Rentrez un nombre entier :");
//récupère le premier entier donné par l'utilisateur et
//le range dans la variable E1
String E1 = Console.ReadLine();

//affiche sur la console : "Rentrer un second nombre entier:"
Console.WriteLine("Rentrez un nombre entier :");
//récupère le second entier donné par l'utilisateur et
//le range dans la variable E2
String E2 = Console.ReadLine();

//parse la chaine de caractère "E1" en un entier "Entier1"
int Entier1 = int.Parse(E1);
//parse la chaine de caractère "E2" en un entier "Entier2"
int Entier2 = int.Parse(E2);

//comparaison des deux entiers
if (Entier1 > Entier2)
{
    //affiche sur la console "l'entier le plus grand est :"
    Console.WriteLine("L'entier le plus grand est : " + Entier1);
}
else
{
    //affiche sur la console "l'entier le plus grand est :"
    Console.WriteLine("L'entier le plus grand est : " + Entier2);
}

// permet de laisser la fenêtre de la console ouverte
Console.ReadLine();