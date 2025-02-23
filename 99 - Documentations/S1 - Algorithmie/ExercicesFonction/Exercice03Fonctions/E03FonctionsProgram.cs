//Ecrire et tester une fonction qui, à partir d'un nombre entier passé en paramètre, renvoie un booléen égal à true si le nombre est pair et false sinon.

//fonction permettant de demander un nombre à l'utilisateur
//et de traiter le nombre entré
//retourne un entier
//prend un string en paramètre
int DemanderUnNombre(string Phrase)
{
    //déclaration de l'entier DemandeNombre
    int DemandeNombre;
    //déclaration du booléen ParseOK
    bool ParseOK;

    //boucle pour gérer si on tape autre chose qu'un entier
    do
    {
        Console.Write(Phrase);
        //boucle do - while
        //fait le tryparse tant que ParseOK est false
        //si le TryParse se fait, true, renvoie de DemandeNombre
        ParseOK = int.TryParse(Console.ReadLine(), out DemandeNombre);
    } while (ParseOK == false);

    //renvoi la valeur donnée à la variable DemandeNombre
    return DemandeNombre;
}

//fonction indiquant si un nombre entier est pair
//retourne un booléen
//prend un entier en paramètre
bool Pair(int NombreSiPair)
{
    //autre solution pour voir si le nombre est pair
    //if (Nombre % 2 == 0)
    //{ return true; }
    //else { return false; }

    //si le Nombre est paire, le retour est true, sinon impair
    return NombreSiPair % 2 == 0;
}

//déclaration et initialisation de la variable Continue pour la boucle while
//ce qui est dans la boucle s'applique tant qu'on tape 'O'
string? Continue = "O";

//comparaison
//tant que la valeur de la variable Continue est égale à "O"
while (Continue == "O" || Continue == "o")
{
    //déclaration et initialisation de l'entier qui récupère le nombre
    int Nombre = DemanderUnNombre("Donner un nombre : ");

    //appel de la fonction
    //si le Nombre est pair
    if (Pair(Nombre))
    {
        Console.WriteLine($"Le nombre {Nombre} est pair !");
    }
    //sinon
    else { Console.WriteLine($"Le nombre {Nombre} est impair !"); }

    //demande à l'utilisateur s'il veut entrer un nouveau nombre
    Console.Write("\nVoulez-vous entrer un nouveau nombre (O/N) ? ");

    //affectation et analyse par rapport à la valeur entrée par l'utilisateur
    Continue = Console.ReadLine();
}