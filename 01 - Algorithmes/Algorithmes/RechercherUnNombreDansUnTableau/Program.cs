// See https://aka.ms/new-console-template for more information

int entrerUnNombre(string phrase)
{
    int nb;
    string saisie;
    bool vrai;

    do
    {
        Console.Write("Entrez un entier positif : ");
        saisie = Console.ReadLine();

        vrai = int.TryParse(saisie, out nb);
    }
    while (!vrai);

    return nb;
}

int[] tableau;
int nombreEntre;

nombreEntre = entrerUnNombre("");

tableau = [8, 16, 32, 64, 128, 256, 512];

for (int i = 0; i < tableau.Length; i++)
{
    if (tableau[i] == nombreEntre)
    {
        Console.WriteLine($"Le nombre entré est présent dans le tableau à la position {i}");
    }
    else
    {
        Console.WriteLine($"Nombre non trouvé en position {i}");
    }
}