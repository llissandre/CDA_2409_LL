// See https://aka.ms/new-console-template for more information

// FONCTIONS
int EntrerUnEntier(string Phrase)
{
    Console.WriteLine(Phrase);

// DECLARATIONS DE VARIABLES DANS LA FONCTION
    int nb;
    bool vrai;
    string saisie;

    do
    {
        Console.WriteLine("Entrez un nombre entier : ");
        saisie = Console.ReadLine();

        vrai = int.TryParse(saisie, out nb);
    }
    while (!vrai);

    // Console.WriteLine("Entrez un nombre entier : ");
    // saisie = Console.ReadLine();
    // nb = int.Parse(saisie);

    return nb;

}

// VARIABLES
int[] nombres;
int A;
int B;
int C;

// TRAITEMENTS
A = EntrerUnEntier("");
B = EntrerUnEntier("");
C = EntrerUnEntier("");

// nombres = new int[3];
// nombres[0] = A;
// nombres[1] = B;
// nombres[2] = C;

// nombres = new int [] {A, B, C};

nombres = [A, B, C];

Array.Sort(nombres);

// AFFICHAGE
Console.WriteLine($"{ Environment.NewLine}Voici les nombres triés : ");
foreach (int nb in nombres)
{
    Console.Write(nb + " ");
}

Console.ReadLine();