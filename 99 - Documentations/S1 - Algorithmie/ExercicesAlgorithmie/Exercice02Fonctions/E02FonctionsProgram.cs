//Ecrire une fonction qui renvoie le résultat de la somme de 2 entiers passés en paramètre.

//Ecrire un Main pour réaliser plusieurs cas de tests.


int DemanderUnNombre(string Phrase)
{
    Console.Write(Phrase);
    int Nombre = int.Parse(Console.ReadLine());
    return Nombre;
}

int LaSomme(int Nombre1, int Nombre2)
{
    int Somme = Nombre1 + Nombre2;
    Console.WriteLine();
    return Somme;
}

string Fin = "O";

while (Fin == "O")
{
    int Nombre1 = DemanderUnNombre("\nEntrer un premier nombre : ");
    int Nombre2 = DemanderUnNombre("Entrer un second nombre : ");

    int Somme = LaSomme(Nombre1, Nombre2);
    Console.WriteLine($"La somme de {Nombre1} et {Nombre2} est {Somme} ");

    Console.Write("\nVoulez-vous refaire un calcul de somme (O/N) ? ");
    Fin = Console.ReadLine();
}