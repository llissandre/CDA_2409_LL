int DemanderNombre(String Phrase)
{
    Console.Write(Phrase);
    int N = int.Parse(Console.ReadLine());

    return N;
}

int Fac(int N)
{
    int Fac = 0;
    int Iterateur = 1;

    while (Iterateur <= N)
    {
        Fac += Iterateur;
        Iterateur++;
    }
    return Fac;
}

//on demande à l'utilisateur d'entrer la valeur de n

int N = DemanderNombre("Entrez un nombre : ");
int Fac1 = Fac(N);

Console.WriteLine("La somme des n entiers inférieurs ou égaux à n est : " + Fac1);

// permet de laisser la fenêtre de la console ouverte
Console.ReadLine();