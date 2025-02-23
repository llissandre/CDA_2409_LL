int DemanderAnneeDeNaissance(string Phrase)
{
    int DemanderAnneeDeNaissance;
    bool ParseOK;
    do
    {
        Console.Write(Phrase);
        ParseOK = int.TryParse(Console.ReadLine(), out DemanderAnneeDeNaissance);
    } while (ParseOK == false);

    return DemanderAnneeDeNaissance;
}

bool AnneeBisextile(int Annee)
{
    return (Annee % 4 == 0 && Annee % 100 != 0) || (Annee % 400 == 0);
}

string? Continue = "O";
while (Continue == "O" || Continue == "o")
{
    int AnneeChoisie = DemanderAnneeDeNaissance("Entrez votre année de naissance : ");
    if (AnneeBisextile(AnneeChoisie) == true)
    {
        Console.WriteLine($"L'année {AnneeChoisie} est bisextile");
    }
    else
    {
        Console.WriteLine($"L'année {AnneeChoisie} n'est pas bisextile");
    }

    Console.Write("\nVoulez-vous entrer une autre année (O/N) ? ");
    Continue = Console.ReadLine();
}