//8.EstPremier
//Etape 1
//Ecrire et tester une fonction qui retournera un booléen pour indiquer si un nombre entier passé en paramètre est premier.

//Enfin, vous afficherez tous les nombres premiers inférieurs à 100.

//Un nombre est premier s'il n'a que 2 diviseurs : 1 et lui-même.

//Etape 2
//Ecrire et tester une fonction qui renvoie un tableau rempli avec tous les nombres premiers inférieurs à un nombre passé en paramètre.


//Etape 2

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

Console.Write("Nombre Choisi : ");
int NbChoisi = int.Parse(Console.ReadLine());

int[] TableauEntiersPremiers = new int[NbChoisi];

//boucle permettant d'afficher les entiers premiers inférieurs au nombre choisi sans mise en page 
//int Iterateur = 0;
//Console.WriteLine("Les Nombres premiers inférieurs au nombre choisi sont : ");
//for (int It = 2; It < NbChoisi; It++)
//{
//    if (NbPremier(It) == true)
//    {
//        {
//            TableauEntiersPremiers[Iterateur] = It;
//            Console.WriteLine(TableauEntiersPremiers[Iterateur]);
//        }
//        Iterateur++;
//    }
//}


int Iterateur = 0;
//boucle permettant d'afficher les entiers premiers inférieurs au nombre choisi avec mise en page, entre crochets, sur une même ligne
for (int It = 2; It < NbChoisi; It++)
{
    //si l'entier est un nombre premier
    if (NbPremier(It) == true)
    {
        //condition pour mettre le premier crochet
        if (It == 2)
        {
            Console.Write("[");
        }

        //boucle pour remplir le tableau
        TableauEntiersPremiers[Iterateur] = It;

        //compris entre 2 et inférieur au nombre choisi
        if (It > 2 && It < TableauEntiersPremiers.Length)
        {
            //permet d'afficher une virgule entre les entiers du tableau
            Console.Write(", ");
        }

        //affiche les entiers premiers
        Console.Write(TableauEntiersPremiers[Iterateur]);
    }

    //condition pour mettre le dernier crochet
    if (It == TableauEntiersPremiers.Length - 1)
    {
        Console.WriteLine("]");
    }
}