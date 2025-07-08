//8.EstPremier
//Etape 1
//Ecrire et tester une fonction qui retournera un booléen pour indiquer si un nombre entier passé en paramètre est premier.

//Enfin, vous afficherez tous les nombres premiers inférieurs à 100.

//Un nombre est premier s'il n'a que 2 diviseurs : 1 et lui-même.


//Etape 1

//fonction indiquant si un nombre entier est premier
//retourne un booléen
//prend un entier en paramètre
bool NbPremier(int Entier)
{
    // boucle allant de 2 au dernier entier inférieur ou égale à la racine de Entier
    for (int It = 2; It <= Math.Sqrt(Entier); It++)
    {
        // si l'entier est divisible par It alors l'entier n'est pas premier
        if (Entier % It == 0)
        {
            return false;
        }
    }
    //l'entier est un nombre premier
    return true;
}

//déclaration du booléen ParseOk;
bool ParseOk;
//déclaration de l'entier NbChoisi;
int NbChoisi;
//boucle do/while avec TryParse qui permet de vérifier que ce que tape l'utilisateur est un entier
//reste dans la boucle tant que l'entrée n'est pas un entier
do
{
    Console.WriteLine("Quel nombre avez-vous choisi ?");
    //boucle do - while
    //fait le tryparse tant que ParseOK est false
    //si le TryParse se fait, true, renvoie NbChoisi
    ParseOk = int.TryParse(Console.ReadLine(), out NbChoisi);
    //vérifie que l'entier soit un nombre entier et qu'il soit supérieur à 2
    if (NbPremier(NbChoisi) && NbChoisi >= 2)
    {
        //nombre premier
        Console.WriteLine("Le nombre est premier");
    }
    else { Console.WriteLine("Le nombre n'est pas premier"); }
} while (ParseOk == false);