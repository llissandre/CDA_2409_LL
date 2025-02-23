//14.Factorielle
//Ecrire et tester une fonction pour calculer la factorielle d'un nombre entier positif n.

//0! = 1
//1! = 1
//2! = 1 * 2
//n! = 1 * 2 * ... * (n-1) *n

//fonction pour demander le nombre choisi
//et de traiter le nombre entré
//retourne un entier
//prend un string en paramètre
int DemanderNombre(String Phrase)
{
    //déclaration de l'entier DemandeNombre
    int NombreChoisi;
    //déclaration du booléen ParseOK
    bool ParseOk;
    //boucle pour gérer si on tape autre chose qu'un entier
    do
    {
        Console.Write(Phrase);
        //boucle do - while
        //fait le tryparse tant que ParseOK est false
        //si le TryParse se fait, true, renvoie de DemandeNombre
        ParseOk = int.TryParse(Console.ReadLine(), out NombreChoisi);
    } while (ParseOk == false);
    //renvoi la valeur donnée à la variable NombreChoisi
    return NombreChoisi;
}

//fonction qui calcule la factorielle du nombre choisi
//retourne un long
//prend un entier en paramètre
long Factorielle(int NombreFactorielle)
{
    if (NombreFactorielle == 0 || NombreFactorielle == 1)
    {
        return 1;
    }
    else
    {
        return NombreFactorielle * Factorielle(NombreFactorielle - 1);
    }
}

//fonction qui calcule la factorielle du nombre choisi
//retourne un long
//prend un entier en paramètre
long Factorielle2(int NombreFactorielle)
{
    int Fact = 1;
    for (int i = 2; i <= NombreFactorielle; i++)
    {
        Fact *= i;
    }
    return Fact;
}

//on utilise la fonction DemanderNombre pour récupérer le nombre choisi par l'utilisateur
int Nombre = DemanderNombre("Entrez un nombre : ");
//on utilise la fonction Factorielle pour calculer la factorielle de Nombre
//long Fac1 = Factorielle(Nombre);


//on écrit le résultat de la factorielle du Nombre Choisi avec la fonction Factorielle
Console.WriteLine($"\nLe résultat du calcul de la factorielle de {Nombre}, calculée avec la fonction Factorielle, est : {Factorielle(Nombre)}");
//on écrit le résultat de la factorielle du Nombre Choisi avec la fonction Factorielle2
Console.WriteLine($"\nLe résultat du calcul de la factorielle de {Nombre}, calculée avec la fonction Factorielle2, est : {Factorielle2(Nombre)}");

// permet de laisser la fenêtre de la console ouverte
Console.ReadLine();