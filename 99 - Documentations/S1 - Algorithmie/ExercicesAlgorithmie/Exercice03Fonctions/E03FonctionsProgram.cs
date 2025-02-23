//Ecrire et tester une fonction qui, à partir d'un nombre entier passé en paramètre, renvoie un booléen égal à true si le nombre est pair et false sinon.

int DemanderUnNombre(string Phrase)
{
    Console.Write(Phrase);
    int Nombre = int.Parse(Console.ReadLine());

    return Nombre;
}

bool Paire(int Nombre)
{
    if (Nombre % 2 == 0)
    { return true; }
    else { return false; }
}


string Fin = "O";

while (Fin == "O")
{
    int Nombre = DemanderUnNombre("Donner un nombre : ");

    if (Paire(Nombre))
    {
        Console.WriteLine($"Le nombre {Nombre} est pair !");
    }
    else { Console.WriteLine($"Le nombre {Nombre} est impair !"); }

    Console.Write("\nVoulez-vous refaire un calcul de somme (O/N) ? ");
    Fin = Console.ReadLine();
}