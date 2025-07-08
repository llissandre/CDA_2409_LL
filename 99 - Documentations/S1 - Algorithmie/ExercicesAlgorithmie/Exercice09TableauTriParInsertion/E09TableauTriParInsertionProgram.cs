//https://fr.wikipedia.org/wiki/Tri_par_insertion

//procédure tri_insertion(tableau T)
int[] Tableau = { 12, 46, 15, 50, 33, 8, 10, 1, 13 };

//pour i de 1 à taille(T) -1
for (int Iterateur = 1; Iterateur < Tableau.Length; Iterateur++)
{
    //# mémoriser T[i] dans x
    //x ← T[i]
    int Temp = Tableau[Iterateur];

    //# décaler les éléments T[0]..T[i-1] qui sont plus grands que x, en partant de T[i-1]
    //j ← i
    //tant que j > 0 et T[j - 1] > x
    //T[j] ← T[j - 1]
    //j ← j - 1

    int Iterateur2 = Iterateur;

    while ((Iterateur2 > 0) && (Tableau[Iterateur2 - 1] > Temp))
    {
        Tableau[Iterateur2] = Tableau[Iterateur2 - 1];
        Iterateur2 -= 1;
    }

    //# placer x dans le "trou" laissé par le décalage
    //T[j] ← x
    Tableau[Iterateur2] = Temp;
}

for (int Iterateur = 0; Iterateur < Tableau.Length; Iterateur++)
{
    Console.Write($"L'élément {Iterateur} du tableau est : " + Tableau[Iterateur] + "\n");
}