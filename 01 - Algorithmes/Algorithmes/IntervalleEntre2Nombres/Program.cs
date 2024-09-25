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

int A;
int B;
int resultat;

A = demanderUnNombre("");
B = demanderUnNombre("");

Console.WriteLine($"{Environment.NewLine}A = {A}");
Console.WriteLine($"B = {B}");
Console.Write("Résultat = ");

if (A < B)
{
    for (int i = A + 1; i < B; i++)
    {
        Console.Write(i + " ");
    }
}
else
{
    for (int i = A - 1; i > B; i--)
    {
        Console.Write(i + " ");
    }
}


Console.ReadLine();