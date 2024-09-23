// See https://aka.ms/new-console-template for more information

int EntrerUnEntier(string Phrase)
{
    Console.WriteLine(Phrase);

    int nb;
    bool vrai;


    do
    {
        Console.WriteLine("Entrez un nombre entier : ");
        string saisie = Console.ReadLine();

        vrai = int.TryParse(saisie, out nb);
    }
    while (!vrai);

    return nb;

}

int A = EntrerUnEntier("");
int B = EntrerUnEntier("");
int C = EntrerUnEntier("");

int[] nombres = new int[3];

nombres[0] = A;
nombres[1] = B;
nombres[2] = C;

Array.Sort(nombres);

Console.WriteLine("Voici les nombres triés : ");
foreach (int nb in nombres)
{
    Console.Write(nb + " ");
}

Console.ReadLine();