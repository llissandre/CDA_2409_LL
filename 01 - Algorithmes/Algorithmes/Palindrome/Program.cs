// See https://aka.ms/new-console-template for more information

int compteur;
int compteurP;

string entrerUneChaineDeCaractere(string Phrase)
{
    Console.Write("Entrez une chaine de caractères : ");
    return Console.ReadLine() ?? "";
}

bool tantQue(char touch)
{
    Console.Write("Voulez-vous saisir une nouvelle chaine de caractères ? (N/O)");
    touch = Console.ReadKey(true).KeyChar;

    if (touch == 'o' || touch == 'O')
    {
        return true;
    }
    return false;
}

bool chaineVide(string phrase)
{
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

    if (compteur == compteurP || compteurP == 0)
    {
        Console.WriteLine("LA CHAINE EST VIDE");
        phrase = entrerUneChaineDeCaractere("");
        return true;
    }
    return false;
}

int controle;
int index;
int vrai;

string phrase = entrerUneChaineDeCaractere("");
controle = 0;

do
{
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

    if (compteur == compteurP || compteurP == 0)
    {
        Console.WriteLine("LA CHAINE EST VIDE");
        phrase = entrerUneChaineDeCaractere("");
    }
}
while (compteur == compteurP || compteurP == 0);


//foreach (char c in phrase)
//{
//    Console.Write(c);
//}

index = phrase.Length - 1;

for (int i = 0; i < index / 2; i++)
{
    if (phrase[i] != phrase[index])
    {
        controle++;
        index--;
    }
}

index = phrase.Length - 1;

if (controle == 0 && index > 1)
{
    Console.WriteLine("La chaîne de caractères est un palindrome");
}
else
{
    Console.WriteLine("La chaîne de caractères n'est pas un palindrome");
}