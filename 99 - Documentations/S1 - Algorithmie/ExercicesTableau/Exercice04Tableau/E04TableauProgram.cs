int[] entiers = new int[7];
entiers[0] = 1;

for (int i = 1; i < entiers.Length; i++)
{
    entiers[i] = entiers[i - 1] + 2;
    Console.WriteLine(entiers[i]);
}

//affiche les entiers impairs 
//3
//5
//7
//9
//11
//13