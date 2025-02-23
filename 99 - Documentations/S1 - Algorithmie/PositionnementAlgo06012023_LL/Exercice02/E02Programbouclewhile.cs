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

int[] TableauDixEntiersSuivants = new int[10];

string? Continue = "O";
while (Continue == "O" || Continue == "o")
{
    int Nombre;
    Nombre = DemanderUnNombre("Entrer un nombre : ");
    //Console.WriteLine($"Le nombre entré est {Nombre}");
    Console.WriteLine("Les dix nombres suivants sont : ");
    int Iterateur = 0;
    while (Iterateur < 10)
    {
        if (Iterateur == 0) { Console.Write("["); }
        Nombre++;
        Console.Write(Nombre);
        TableauDixEntiersSuivants[Iterateur] = Nombre;
        if (Iterateur != TableauDixEntiersSuivants.Length - 1) { Console.Write(", "); }
        Iterateur++;
    }
    Console.Write("]\n");

    Console.Write("\nVoulez-vous entrer un nouveau nombre (O/N) ? ");
    Continue = Console.ReadLine();
}