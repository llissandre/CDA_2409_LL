//fonction pour demander le nombre souhaité
int DemanderNombre(String Phrase)
{
    Console.Write(Phrase);
    int N = int.Parse(Console.ReadLine());

    return N;
}

int SommeEntiersPairs(int N)
{
    //déclaration des entiers
    int Somme = 0;
    int Entiers = 2;

    //tant que le nombre d'entiers pairs trouvés est inférieur au N renseigné
    while (Entiers <= N * 2)
    {
        //ajout des entiers pairs à la somme des entiers pairs
        Somme += Entiers;
        Console.WriteLine(Entiers);

        //incrémentation des entiers
        Entiers += 2;
    }
    return Somme;
}

//on demande à l'utilisateur d'entrer la valeur de n
int N = DemanderNombre("Entrez un nombre : ");
int SommeEntiersPairs1 = SommeEntiersPairs(N);

//on écrit la somme des entiers pairs
Console.WriteLine($"\nLa somme des {N} entiers inférieurs ou égaux à n pairs est : " + SommeEntiersPairs1 + " !");

// permet de laisser la fenêtre de la console ouverte
Console.ReadLine();