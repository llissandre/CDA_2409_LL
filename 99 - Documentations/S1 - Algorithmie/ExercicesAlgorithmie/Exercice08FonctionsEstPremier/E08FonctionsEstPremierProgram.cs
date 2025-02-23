//8.EstPremier
//Etape 1
//Ecrire et tester une fonction qui retournera un booléen pour indiquer si un nombre entier passé en paramètre est premier.

//Enfin, vous afficherez tous les nombres premiers inférieurs à 100.

//Un nombre est premier s'il n'a que 2 diviseurs : 1 et lui-même.

//Etape 2
//Ecrire et tester une fonction qui renvoie un tableau rempli avec tous les nombres premiers inférieurs à un nombre passé en paramètre.


//étape 1
bool NbPremier(int Entier)
{
    for (int It = 2; It <= Math.Sqrt(Entier); It++)
    { if (Entier % It == 0) { return false; } }
    return true;
}
Console.WriteLine("Quel nombre avez-vous choisi ?");
Console.Write("Nombre Choisi : ");
int NbChoisi = int.Parse(Console.ReadLine());

int[] TableauEntiersPremiers = new int[NbChoisi];

//2
for (int It = 0; It < NbChoisi; It++)
{
    if (NbPremier(It) == true)
    {
        TableauEntiersPremiers[It] = It;
        // Pour 1 et 1bis Console.WriteLine(It);
    }

}

Console.Write("Le Nombre premier inférieur au nombre choisi est : ");

for (int It = 0; It < NbChoisi; It++)
{
    if (NbPremier(It) == true)
    {
        if (It == 0) { Console.Write("["); }
        for (int Iterateur = 0; Iterateur < NbChoisi; Iterateur++)
        {
            TableauEntiersPremiers[Iterateur] = It;
        }
        if (It > 0 && It < TableauEntiersPremiers.Length) { Console.Write(", "); }
        Console.Write(TableauEntiersPremiers[It]);
    }
    if (It == TableauEntiersPremiers.Length - 1) { Console.WriteLine("]"); }
}


//1
//Console.WriteLine("Quel entier avez-vous choisi ? ");
//int NbChoisi = int.Parse(Console.ReadLine());
//if (NbPremier(NbChoisi))
//{
//    Console.WriteLine("Le nombre est premier");
//}
//else { Console.WriteLine("Le nombre n'est pas premier"); }

//1bis
//for (int It = 0; It < 100; It++)
//{
//    if (NbPremier(It) == true)
//    {
//        Console.WriteLine(It);
//    }
//}