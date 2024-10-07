// See https://aka.ms/new-console-template for more information

string entrerUnePhrase(string phrase)
{
    Console.Write("Entrer une phrase : ");
    return Console.ReadLine();
}

char entrerUnCaractere(char caractere)
{
    Console.Write("Entrer un caractère : ");
    return Console.ReadKey().KeyChar;
}

string phrase;
char caractere;
int compteur;
int compteurP;

phrase = entrerUnePhrase("");
compteur = 0;
compteurP = 0;

foreach (char c in phrase)
{
    compteur++;

    if (c == '.')
    {
        compteurP++;
    }
}

if (phrase.Length == 0 || compteur == compteurP)
{
    Console.WriteLine("LA CHAINE EST VIDE");
}
else
{
    compteur = 0;
    caractere = entrerUnCaractere(' ');

    foreach (char c in phrase)
    {
        if (c == caractere)
        {
            compteur++;
        }
    }

    if (compteur == 0)
    {
        Console.WriteLine($"{Environment.NewLine}La lettre {caractere} n'est pas présente");
    }
    else
    {
        Console.WriteLine($"{Environment.NewLine}La lettre {caractere} est présente {compteur} fois");
    }
}