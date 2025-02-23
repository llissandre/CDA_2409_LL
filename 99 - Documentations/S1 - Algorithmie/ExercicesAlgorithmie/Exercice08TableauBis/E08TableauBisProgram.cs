
int[] Tableau1 = { 4, 8, 7, 12 };
int[] Tableau2 = { 3, 6 };
int Produit = 0;
int Schtroumpf = 0;
int Iterateur2 = 0;

for (int Iterateur1 = 0; Iterateur1 <= Tableau1.Length; Iterateur1++)
{
    if ((Iterateur1 == Tableau1.Length) && (Iterateur2 < Tableau2.Length - 1))
    {
        Iterateur2++;
        Iterateur1 = 0;
    }

    if ((Iterateur1 < Tableau1.Length) && (Iterateur2 < Tableau2.Length))
    {
        Produit = Tableau1[Iterateur1] * Tableau2[Iterateur2];
        Schtroumpf += Produit;
    }
}

Console.WriteLine(Schtroumpf);