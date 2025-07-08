int DemanderNombre(String Phrase)
{
    Console.Write(Phrase);
    int N = int.Parse(Console.ReadLine());

    return N;
}

string FaireCalcul(String Phrase)
{
    Console.WriteLine(Phrase);
    String Souhait = Console.ReadLine();

    return Souhait;
}
int Calcul(int N)
{
    //déclaration des entiers
    int Somme = 0;
    int Entiers = 2;

    //tant que le nombre d'entiers pairs trouvés est inférieur au N renseigné
    while (Entiers <= N * 2)
    {
        //ajout des entiers pairs à la somme des entiers pairs
        Somme += Entiers;

        //incrémentation des entiers
        Entiers += 2;
    }
    return Somme;
}


String Souhait = FaireCalcul("Voulez-vous faire le calcul ? o/n");

if (Souhait == "O" || Souhait == "o")
{
    do
    {
        ///on demande à l'utilisateur d'entrer la valeur de n
        int N = DemanderNombre("Entrez un nombre : ");
        int Sommes = Calcul(N);

        //on calcule la somme des n entiers inférieurs ou égaux à n
        Console.WriteLine($"La somme des {N} entiers inférieurs ou égaux à n est : " + Sommes + "\n");

        Souhait = FaireCalcul("Voulez-vous refaire le calcul ? o/n ");
    } while (Souhait == "O" || Souhait == "o");
}

else
{
    Console.WriteLine("Au revoir !");
    return;
}