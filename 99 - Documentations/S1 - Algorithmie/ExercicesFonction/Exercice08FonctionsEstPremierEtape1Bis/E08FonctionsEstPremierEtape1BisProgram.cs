// 8.EstPremier
//Etape 1
//Ecrire et tester une fonction qui retournera un booléen pour indiquer si un nombre entier passé en paramètre est premier.
//Enfin, vous afficherez tous les nombres premiers inférieurs à 100.

//Un nombre est premier s'il n'a que 2 diviseurs : 1 et lui-même.

//fonction indiquant si un nombre entier est premier
//retourne un booléen
//prend un entier en paramètre

//Etape 1Bis

//fonction indiquant si un nombre entier est premier
//retourne un booléen
//prend un entier en paramètre
bool NbPremier(int Entier)
{
    // boucle allant de 2 au dernier entier inférieur ou égale à la racine de Entier
    for (int It = 2; It <= Math.Sqrt(Entier); It++)
    {
        //si l'entier est divisible par It alors l'entier n'est pas premier
        if (Entier % It == 0)
        { 
            return false; 
        }
    }
    //l'entier est un nombre premier
    return true;
}

//boucle qui va analyser les entiers de 2 à 99
for (int It = 2; It < 100; It++)
{
    //appel de la fonction
    //si l'entier est un nombre premier
    if (NbPremier(It) == true)
    {
        //alors on l'affiche
        Console.WriteLine(It);
    }
}