int DemanderNombre(String Phrase)
{
    Console.Write(Phrase);
    int N = int.Parse(Console.ReadLine());

    return N;
}

int Fac(int N)
{
    int Fac = 1;
    int Calcul = 1;

    while (Calcul <= N)
    {
        Fac = Fac * Calcul;
        Calcul++;
    }
    return Fac;
}


//on demande à l'utilisateur d'entrer la valeur de n
int N = DemanderNombre("Entrez un nombre : ");
int Fac1 = Fac(N);

Console.WriteLine("La factorielle du nombre est : " + Fac1 + " !");

// permet de laisser la fenêtre de la console ouverte
Console.ReadLine();