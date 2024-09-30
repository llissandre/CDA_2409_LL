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

bool nbPremier(int nombre)
{
    double math;
    math=Math.Sqrt(nombre);

    for (int i = 2; i <= Math.Sqrt(nombre); i++)
    {
        if (nombre % i == 0)
        {
            return false;
        }
    }

    if (nombre > 1)
        return true;
    else return false;
}

int nombre;
//int nbP;

nombre = demanderUnNombre("");
//nbP = 0;


if (nbPremier(nombre))
{
    Console.WriteLine("Il s'agit d'un nombre premier");
}
else
{
    Console.WriteLine("Il ne s'agit pas d'un nombre premier");
}

//for (int i = 1; i <= nombre / 2; i++)
//{
//    if (nombre % i == 0)
//    {
//        nbP ++;
//    }
//}

//if (nbP == 1)
//{
//    Console.WriteLine("Il s'agit d'un nombre premier");
//}
//else
//{
//    Console.WriteLine("Il ne s'agit pas d'un nombre premier");
//}

//Console.ReadLine();
