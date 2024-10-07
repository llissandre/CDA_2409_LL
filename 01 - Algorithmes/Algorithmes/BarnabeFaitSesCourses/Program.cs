// See https://aka.ms/new-console-template for more information


int sommeADepenser(string phrase)
{
    int somme;
    string saisie;
    bool vrai;

    Console.WriteLine(Phrase);

    do
    {
        Console.Write("Entrez la somme à dépenser : ");
        saisie = Console.ReadLine();
        vrai=int.TryParse(saisie, out somme);
    }
    while (!vrai);

    return somme;
}

int store;
int somme;

store = 0;
somme = sommeADepenser("");

do
{

} while (somme>1);