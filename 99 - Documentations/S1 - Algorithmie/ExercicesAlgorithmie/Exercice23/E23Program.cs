int DemanderNombre(String Phrase)
{
    Console.Write(Phrase);
    int Nombre = int.Parse(Console.ReadLine());

    return Nombre;
}

//Le programme tire au sort un nombre, entre 1 et 100.
Random ObjRandom = new Random();
int NbATrouver = ObjRandom.Next(100);
Console.WriteLine("NbATrouver : " + NbATrouver + "\n");

int Compteur = 0;
int Nombre = DemanderNombre("Entrez un nombre : ");

while (NbATrouver != Nombre)
{
    //Quand l'utilisateur saisit un nombre, l'ordinateur affiche :
    //+si le nombre saisi est trop petit
    //- si le nombre saisi est trop grand
    if (Nombre < NbATrouver)
    {
        Console.WriteLine("Le nombre choisi est trop petit !\n");
    }
    else
    {
        Console.WriteLine("Le nombre choisi est trop grand !\n");
    }

    Compteur++;
    Nombre = DemanderNombre("Entrez un nombre : ");
}

Console.WriteLine("Nombre de coups pour avoir trouver le nombre juste : " + Compteur);

//En plus, le programme affichera le nombre de coups pour trouver le nombre.
//Bravo si le nombre est trouvé
Console.WriteLine("Bravo !!!");