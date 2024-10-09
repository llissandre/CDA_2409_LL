// See https://aka.ms/new-console-template for more information

int[] tableau;
int temp;
int temp2;
int index;

tableau = [128, 64, 8, 512, 16, 32, 256];

// Afficher le tableau d'origine
foreach (int entier in tableau)
{
    Console.Write($"{entier} ");
}

// Trier le tableau
Console.WriteLine(Environment.NewLine);

index = 0;

int i;
int j;

for (i = 0; i < tableau.Length; i++)
{
    temp = tableau[i];
    temp2 = tableau[i];

    for (j = i + 1; j < tableau.Length; j++)
    {
        if (tableau[j] < temp && tableau[j] < temp2)
        {
            temp2 = tableau[j];
            index = j;
        }
    }

    tableau[index] = temp;
    tableau[i] = temp2;
}

Console.WriteLine(Environment.NewLine);

// Afficher le tableau après le tri
foreach (int entier in tableau)
{
    Console.Write($"{entier} ");
}