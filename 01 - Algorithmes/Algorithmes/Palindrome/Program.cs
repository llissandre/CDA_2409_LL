// See https://aka.ms/new-console-template for more information


string entrerUneChaineDeCaractere(string Phrase)
{
    Console.Write("Entrez une chaine de caractères : ");
    return Console.ReadLine();
}

string phrase = entrerUneChaineDeCaractere("");
char caractere;
int compteur = 0;
int compteurP = 0;


do
{
    foreach (char c in phrase)
    {
        compteur++;

        if (c == '.')
        {
            compteurP++;
        }
    }

    Console.WriteLine("LA CHAINE EST VIDE");
    phrase = entrerUneChaineDeCaractere("");
}
while (compteur == compteurP);

if (phrase.Length == 0 || compteur == compteurP)
{
    Console.WriteLine("LA CHAINE EST VIDE");
}


else
{
    compteur = 0;
    phrase = entrerUneChaineDeCaractere("");

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