int[] entiers = new int[10];
entiers[0] = 1;
entiers[1] = 1;

for (int i = 2; i < entiers.Length; i++)
{
    entiers[i] = entiers[i - 1] + entiers[i - 2];
    Console.WriteLine(entiers[i]);
}

//affiche la somme de la valeur des deux cases précédentes
//E[2] : 2
//E[3] : 3
//E[4] : 5
//E[5] : 8
//E[6] : 13
//E[7] : 21
//E[8] : 34
//E[9] : 55