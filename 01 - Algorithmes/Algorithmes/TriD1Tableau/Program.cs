// See https://aka.ms/new-console-template for more information

int[] tableau;
int temp;
int index;
int stock;

tableau = [128, -64, -8, 512, 16, -32, -256];

// Afficher le tableau d'origine
foreach (int nbr in tableau)
{
    Console.Write($"{nbr} ");
}

// Trier le tableau
Console.WriteLine(Environment.NewLine);

index = 0;
int i;
int j;

for (i = 0; i < tableau.Length; i++)
{
    stock = int.MaxValue;
    temp = 0;

    for (j = i; j < tableau.Length; j++)
    {
        if (tableau[j] < stock)
        {
            stock = tableau[j];
            index = j;
        }
    }

    temp = tableau[index];
    tableau[index] = tableau[i];
    tableau[i] = temp;
}

Console.WriteLine(Environment.NewLine);

// Afficher le tableau après le tri
foreach (int nbr in tableau)
{
    Console.Write($"{nbr} ");
}