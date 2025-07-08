int Tableau = 6;

int[] Entiers = new int[Tableau];

for (int Iteration = 0; Iteration < Entiers.Length; Iteration++)
{
    Entiers[Iteration] = Iteration * Iteration;
    Console.WriteLine(Entiers[Iteration]);
}

//affiche le résultat des produit
//0
//1
//4
//9
//16
//25