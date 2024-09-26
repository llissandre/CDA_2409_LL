// See https://aka.ms/new-console-template for more information

int demanderUnNombreEntiers(string Phrase)
{
    int nb;
    string saisie;
    bool vrai;

    Console.WriteLine(Phrase);

    do
    {
        Console.WriteLine("Entrer un nombre");
        saisie = Console.ReadLine();
        vrai=int.TryParse(saisie, out nb);
    }
    while (!vrai);

    return nb;
}

Random rand;
int nombre;



