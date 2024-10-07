// See https://aka.ms/new-console-template for more information


int sommeADepenser(string phrase)
{
    int somme;
    string saisie;
    bool vrai;

    Console.WriteLine(phrase);

    do
    {
        Console.Write("Entrez une somme à dépenser supérieure à 1 : ");
        saisie = Console.ReadLine();
        vrai = int.TryParse(saisie, out somme);
    }
    while (!vrai || somme < 2);

    return somme;
}

int store;
int sommeAD;
int sommeD;

store = 0;
sommeAD = sommeADepenser("");
sommeD = 0;

do
{
    store++;
    sommeD = sommeAD / 2 + 1;
    sommeAD = sommeAD - sommeD;
    if (sommeAD < 2)
    {
        sommeD = sommeD + sommeAD;
        sommeAD = 0;
    }
    Console.WriteLine($"SD" + sommeD);
    Console.WriteLine($"SAD" + sommeAD);
}
while (sommeAD > 1 && sommeAD > (sommeAD / 2) + 1);



Console.WriteLine($"Somme restant à dépenser : {sommeAD}");
Console.WriteLine($"Nombre de magasins dans lesquels Barnabé a acheté : {store}");