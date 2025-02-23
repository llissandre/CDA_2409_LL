int[] Tableau = { 12, 46, 15, 50, 33, 8, 10, 1, 13 };
int Temp = 0;

bool Somethinghaschanged = true;

while (Somethinghaschanged == true)
{
    Somethinghaschanged = false;
    for (int Iterateur = 0; Iterateur < Tableau.Length - 1; Iterateur++)
    {
        if (Tableau[Iterateur] < Tableau[Iterateur + 1])
        {
            Console.WriteLine($"L'itérateur {Iterateur} est inférieur à l'itérateur {Iterateur + 1}");
        }

        else
        {
            Console.WriteLine($"L'itérateur {Iterateur} est supérieur à l'itérateur {Iterateur + 1}");
            Temp = Tableau[Iterateur];
            Tableau[Iterateur] = Tableau[Iterateur + 1];
            Tableau[Iterateur + 1] = Temp;
            Somethinghaschanged = true;
        }
    }
}

for (int Iterateur = 0; Iterateur < Tableau.Length; Iterateur++)
{
    Console.Write($"L'élément {Iterateur} du tableau est : " + Tableau[Iterateur] + "\n");
}
