int DemanderUnNombre(string Phrase)
{
    int DemandeNombre;
    bool ParseOK;
    do
    {
        Console.Write(Phrase);
        ParseOK = int.TryParse(Console.ReadLine(), out DemandeNombre);
    } while (ParseOK == false);

    return DemandeNombre;
}

bool Pair(int SiNombrePair)
{
    return SiNombrePair % 2 == 0;
}

string? Continue = "O";
while (Continue == "O" || Continue == "o")
{
    int NombreChoisi = DemanderUnNombre("Entrez un nombre entier compris entre 1 et 100 : ");
    Console.WriteLine();
    Console.Write($"Le résultat de la suite de Syracuse est : [{NombreChoisi}");
    do
    {
        if (Pair(NombreChoisi))
        {
            NombreChoisi = NombreChoisi / 2;
            Console.Write($", {NombreChoisi}");
        }
        else
        {
            NombreChoisi = NombreChoisi * 3 + 1;
            Console.Write($", {NombreChoisi}");
        }

    } while (NombreChoisi != 1);
    Console.WriteLine("]");
    Console.Write("\nVoulez-vous entrer un nouveau nombre (O/N) ? ");
    Continue = Console.ReadLine();
}