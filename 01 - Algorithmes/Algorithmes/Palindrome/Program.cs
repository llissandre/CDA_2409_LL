// See https://aka.ms/new-console-template for more information

int compteur;
int compteurP;

string entrerUneChaineDeCaractere(string phrase)
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

bool chaineVide(ref string chaineDeCaracteres)
{
    compteur = 0;
    compteurP = 0;

    foreach (char c in chaineDeCaracteres)
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
        chaineDeCaracteres = entrerUneChaineDeCaractere("");
        return true;
    }
    return false;
}

string chaineDeCaracteres;
int controle;
int index;
bool controleChaine;

do
{
    chaineDeCaracteres = entrerUneChaineDeCaractere("");
    controle = 0;

    do
    {
        controleChaine = chaineVide(ref chaineDeCaracteres);
    }
    while (controleChaine);

    index = chaineDeCaracteres.Length - 2;

    for (int i = 0; i < index / 2; i++)
    {
        if (chaineDeCaracteres[i] != chaineDeCaracteres[index])
        {
            controle++;
            index--;
        }
    }

    index = chaineDeCaracteres.Length - 2;

    if (controle == 0 && index >= 1)
    {
        Console.WriteLine("La chaîne de caractères est un palindrome");
    }
    else
    {
        Console.WriteLine("La chaîne de caractères n'est pas un palindrome");
    }

}
while (Console.ReadKey().Key != ConsoleKey.Escape);