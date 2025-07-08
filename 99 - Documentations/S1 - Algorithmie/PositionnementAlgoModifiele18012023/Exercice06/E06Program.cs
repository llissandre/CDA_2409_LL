
int DemanderUnNombre(string Phrase)
{
    int DemanderLeNombre;
    bool ParseOK;
    do
    {
        Console.Write(Phrase);
        ParseOK = int.TryParse(Console.ReadLine(), out DemanderLeNombre);
    } while (ParseOK == false);

    return DemanderLeNombre;
}

bool Parfait(int LeNombre)
{
    int CompteurDiviseurs = 0;
    for (int Compteur = 1; Compteur < LeNombre; Compteur++)
    {
        if (LeNombre % Compteur == 0)
        {
            CompteurDiviseurs += Compteur;
        }
    }
    if (CompteurDiviseurs == LeNombre)
    {
        return true;
    }
    return false;
}


string? Continue = "O";
while (Continue == "O" || Continue == "o")
{
    int NbChoisi = DemanderUnNombre("Quel nombre avez-vous choisi ?");

    if (Parfait(NbChoisi) == true)
    {
        Console.WriteLine("Le nombre est parfait");
    }
    else { Console.WriteLine("Le nombre n'est pas parfait"); }
    Console.Write("\nVoulez-vous entrer une autre année (O/N) ? ");
    Continue = Console.ReadLine();
}