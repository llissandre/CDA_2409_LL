
int[] Tableau = { 1, 2, 4, 2, 4, 2, 8, 12 };

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
    int NombreChoisi = DemanderUnNombre("\nEntrez un nombre entier : ");
    Console.WriteLine();

    int Iterateur2 = 0;

    for (int Iterateur1 = 0; Iterateur1 < Tableau.Length; Iterateur1++)
    {
        if (NombreChoisi == Tableau[Iterateur1])
        {
            Iterateur2++;
        }
    }

    if (Iterateur2 == 0)
    {
        Console.WriteLine($"Le nombre {NombreChoisi} n'est pas présent dans le tableau");
    }

    else if (Iterateur2 == 1)
    {
        Console.WriteLine($"Le nombre {NombreChoisi} est présent une seule fois dans le tableau");
    }

    else
    {
        Console.WriteLine($"Le nombre {NombreChoisi} est présent {Iterateur2} fois dans le tableau");
    }
    Console.Write("\nVoulez-vous entrer un nouveau nombre (O/N) ? ");
    Continue = Console.ReadLine();
}