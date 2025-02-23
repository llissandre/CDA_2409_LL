//7.Somme de 2 tableaux
//Ecrire un programme qui fait la somme de 2 tableaux de même longueur préalablement remplis.
//Exemple :
//Tableau 1
//    4   8   7   9   1   5   4   6
//    Tableau 2
//    7   6   5   2   1   3   7   4
//    Résultat: somme du tableau1 et du tableau 2
//    11	14	12	11	2	8	11	10

int[] Tableau1 = { 1, 2, 3, 4, 5, 6, 7, 8 };
int[] Tableau2 = { 9, 10, 11, 12, 13, 14, 15, 16 };
int[] Tableau3 = new int[Tableau1.Length];

Console.Write("Le résultat de la somme des deux tableaux est : ");
for (int Iterateur = 0; Iterateur < Tableau1.Length; Iterateur++)
{
    if (Iterateur == 0) { Console.Write("["); }
    //Console.Write("La somme des deux tableaux est : " + Tableau1[Iterateur] + Tableau2[Iterateur]);
    Tableau3[Iterateur] = Tableau1[Iterateur] + Tableau2[Iterateur];
    Console.Write(Tableau3[Iterateur]);
    if (Iterateur < Tableau1.Length - 1) { Console.Write(", "); }
}
Console.WriteLine("]");