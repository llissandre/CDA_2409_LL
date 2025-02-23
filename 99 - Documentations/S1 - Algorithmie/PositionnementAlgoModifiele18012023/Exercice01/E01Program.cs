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

string? Continue = "O";
while (Continue == "O" || Continue == "o")
{
    int Nombre;
    do
    {
        Nombre = DemanderUnNombre("Entrer un nombre entre 1 et 3 (1 et 3 compris) : ");
    } while (Nombre < 1 || Nombre > 3);

    Console.WriteLine($"Vous avez entré {Nombre} qui est bien compris entre 1 et 3");

    Console.Write("\nVoulez-vous entrer un nouveau nombre (O/N) ? ");
    Continue = Console.ReadLine();
}