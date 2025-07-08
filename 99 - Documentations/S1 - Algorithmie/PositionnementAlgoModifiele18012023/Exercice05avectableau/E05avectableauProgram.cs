int[] Tableau = { 1900, 1960, 2000, 2004, 2005, 2020, 2021 };



bool AnneeBisextile(int Annee)
{
    return (Annee % 4 == 0 && Annee % 100 != 0) || (Annee % 400 == 0);
}


for (int Iterateur = 0; Iterateur < Tableau.Length; Iterateur++)
{
    int AnneeDuTableau = Tableau[Iterateur];
    if (AnneeBisextile(AnneeDuTableau) == true)
        {
        Console.WriteLine($"L'année {AnneeDuTableau} est bisextile");
    }
    else
    {
        Console.WriteLine($"L'année {AnneeDuTableau} n'est pas bisextile");
    }
}