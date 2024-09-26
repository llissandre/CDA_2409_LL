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
int nbPremier;

nombre = demanderUnNombre("");
nbPremier = 0;

for (int i = 1; i <= nombre / 2; i++)
{
    if (nombre % i == 0)
    {
        nbPremier ++;
    }
}

if (nbPremier == 1)
{
    Console.WriteLine("Il s'agit d'un nombre premier");
}
else
{
    Console.WriteLine("Il ne s'agit pas d'un nombre premier");
}

//Console.ReadLine();
