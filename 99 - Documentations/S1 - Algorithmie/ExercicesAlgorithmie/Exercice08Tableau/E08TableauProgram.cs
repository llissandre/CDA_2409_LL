
//int[] Tableau1 = new int[Nombredevaleur];
//int[] Tableau2 = new int[Nombredevaleur];

int[] Tableau1 = { 4, 8, 7, 12 };
int[] Tableau2 = { 3, 6 };
int Produit = 0;
int Schtroumpf = 0;

for (int Iterateur = 0; Iterateur < Tableau1.Length; Iterateur++)
{
    Produit = Tableau2[0] * Tableau1[Iterateur];
    Schtroumpf += Produit;
}

for (int Iterateur = 0; Iterateur < Tableau1.Length; Iterateur++)
{
    Produit = Tableau2[1] * Tableau1[Iterateur];
    Schtroumpf += Produit;

}

Console.WriteLine(Schtroumpf);