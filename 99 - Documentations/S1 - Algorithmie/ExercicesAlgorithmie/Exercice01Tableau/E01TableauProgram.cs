const int NB_NOTES = 5;

float[] Notes = new float[NB_NOTES]; //Un tableau pour ranger les 5 notes (réel)
float Somme = 0; //Déclaration du flottant Somme pour le calcul des sommes des notes
int Notesinferieures = 0; //Déclaration de Noteinferieure pour le calcul des notes inférieures
int Notessuperieures = 0; //Déclaration de Notesuperieure pour le calcul des notes supérieures

//Vous devez entrer cinq notes
Console.WriteLine("Vous devez entrer cinq notes !");

//Saisir les 5 notes
for (int Iterateur = 0; Iterateur < NB_NOTES; Iterateur++)
{
    Console.Write("Entrez une note : ");
    Notes[Iterateur] = float.Parse(Console.ReadLine());

    if (Notes[Iterateur] >= 10)
    {
        Notessuperieures++;
    }

    else
    {
        Notesinferieures++;
    }
    Somme += Notes[Iterateur];
}

float moyenne = Somme / NB_NOTES; //Calculer la moyenne

//Afficher le résultat
Console.WriteLine("\nLa moyenne est : " + moyenne);

//Afficher le nombre de notes inféreures à 10
Console.WriteLine("Le nombre de notes inférieures à 10 est : " + Notesinferieures);

//Afficher le nombre de notes supérieures ou égales à 10
Console.WriteLine("Le nombre de notes supérieures ou égales à 10 est : " + Notessuperieures);
