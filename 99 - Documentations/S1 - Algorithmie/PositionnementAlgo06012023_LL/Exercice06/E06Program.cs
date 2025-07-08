
int DemanderUnNombre(string Phrase)
{
    int Nombre;
    bool ParseOK;
    do
    {
        Console.Write(Phrase);
        ParseOK = int.TryParse(Console.ReadLine(), out Nombre);
    } while (ParseOK == false);

    return Nombre;
}

bool Parfait(int Nombre)
{
    int CompteurDiviseurs = 0;
    for (int Compteur = 1; Compteur < Nombre; Compteur++)
    {
        if (Nombre % Compteur == 0)
        {
            CompteurDiviseurs += Compteur;
        }
    }
    if (CompteurDiviseurs == Nombre && Nombre > 1)
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