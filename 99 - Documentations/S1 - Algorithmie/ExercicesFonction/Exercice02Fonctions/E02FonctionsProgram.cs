//Ecrire une fonction qui renvoie le résultat de la somme de 2 entiers passés en paramètre.

//Ecrire un Main pour réaliser plusieurs cas de tests.

//fonction demande d'entrer un nombre
//retourne un entier
//prend un string en paramètre
int DemanderUnNombre(string Phrase)
{
    //initialisation du booléen ParseOK
    bool ParseOK;
    //initialisation de l'entier DemandeNombre
    int DemandeNombre;

    //boucle pour gérer si on tape autre chose qu'un entier
    do
    {
        Console.Write(Phrase);
        //boucle do - while
        //fait le tryparse tant que ParseOK est false
        //si le TryParse se fait, true, renvoie de DemandeNombre
        ParseOK = int.TryParse(Console.ReadLine(), out DemandeNombre);
    } while (ParseOK == false);

    //renvoi le nombre entré par l'utilisateur
    return DemandeNombre;
}

//fonction permettant de faire la somme de deux nombres
//retourne un entier
//prend deux entiers en paramètre
int LaSomme(int Nombre1, int Nombre2)
{
    int Somme = Nombre1 + Nombre2;
    return Somme;
}

//déclare et initialise un string
string? Continue = "O";
//boucle tant que l'on tape O ou o
while (Continue == "O" || Continue == "o")
{
    //appel de la fonction DemanderUnNombre pour le premier nombre
    int Nombre1 = DemanderUnNombre("\nEntrer un premier nombre : ");
    //appel de la fonction DemanderUnNombre pour le premier nombre
    int Nombre2 = DemanderUnNombre("\nEntrer un second nombre : ");
    //appel de la fonction LaSomme pour effectuer la somme
    int Somme = LaSomme(Nombre1, Nombre2);
    //affichage du résultat
    Console.WriteLine($"La somme de {Nombre1} et {Nombre2} est {Somme} ");

    //demande à l'utilisateur s'il souhaite refaire le calcul
    Console.Write("\nVoulez-vous refaire un calcul de somme (O/N) ? ");
    //affectation et analyse par rapport à la valeur entrée par l'utilisateur
    Continue = Console.ReadLine();
}