// See https://aka.ms/new-console-template for more information

int demanderUnNombre(string Phrase)
{
    int nb;
    string saisie;
    bool vrai;

    Console.Write(Phrase);

    do
    {
        Console.Write("Entrez un entier : ");
        saisie = Console.ReadLine();
        vrai = int.TryParse(saisie, out nb);
    } while (!vrai);

    return nb;
}

int nombre;

nombre = demanderUnNombre("");

for (int i = 2; i <= nombre / 2; i++)
{
    if (nombre % i == 0)
    {
        Console.WriteLine(i);
    }
}