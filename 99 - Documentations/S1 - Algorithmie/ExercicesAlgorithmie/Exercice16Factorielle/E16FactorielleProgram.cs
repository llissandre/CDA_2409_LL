int DemanderNombre(String Phrase)
{
    Console.Write(Phrase);
    int N = int.Parse(Console.ReadLine());

    return N;
}

int Fac(int N)
{
    int Fac = 1;
    int Iterateur = 1;

    while (Iterateur <= N)
    {
        Fac = Fac * Iterateur;
        Iterateur++;
    }
    return Fac;
}

//on demande à l'utilisateur d'entrer la valeur de n

int N = DemanderNombre("Entrez un nombre : ");
int Factorielle = Fac(N);

Console.WriteLine($"La factorielle des {N} entiers inférieurs ou égaux à n est : " + Factorielle + $" (Soit : !{N})");

// permet de laisser la fenêtre de la console ouverte
Console.ReadLine();