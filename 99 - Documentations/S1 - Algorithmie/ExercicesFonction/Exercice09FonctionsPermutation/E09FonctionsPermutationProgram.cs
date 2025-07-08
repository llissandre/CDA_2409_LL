//9.Permutation
//Ecrire et tester une fonction qui permute les valeurs de 2 chaines de caractères.

//void Permutation2(string Valeur1, string Valeur2)
//{
//    String Temp = Valeur1;
//    Valeur1 = Valeur2;
//    Valeur2 = Temp;
//}


//procédure permettant d'effectuer la permutation 
//void Permutation(ref string Valeur1, ref string Valeur2)
//{
//    String Temp = Valeur1;
//    Valeur1 = Valeur2;
//    Valeur2 = Temp;
//}

////exemple de l'exercice avec la permutation de deux chaines de caractères

////déclaration et initialisation de la valeur de Chaine1
//string Chaine1 = "LaValeurDeChaine1";
////déclaration et initialisation de la valeur de Chaine2
//String Chaine2 = "LaValeurDeChaine2";

////on affiche les valeurs de Chaine1 et de Chaine2 avant permutation
//Console.WriteLine($"La valeur de Chaine1 est {Chaine1}");
//Console.WriteLine($"La valeur de Chaine2 est {Chaine2}");

////on appelle la procédure Permutation pour effectuer la permutation des chaines de caractères
//Permutation(ref Chaine1, ref Chaine2);

//Console.WriteLine();
////on affiche les valeurs de Chaine1 et de Chaine2 après permutation
//Console.WriteLine($"La nouvelle valeur de Chaine1 est {Chaine1}");
//Console.WriteLine($"La nouvelle valeur de Chaine2 est {Chaine2}");


////exemple de l'exercice avec la permutation de deux entiers

//procédure permettant d'effectuer la permutation
//prend un entier en paramètre
void Permutation(ref int Nb1, ref int Nb2)
{
    int Tmp = Nb1;
    Nb1 = Nb2;
    Nb2 = Tmp;
}


//déclaration et initialisation de la valeur de Nombre1
int Nombre1 = 1;
//déclaration et initialisation de la valeur de Nombre2
int Nombre2 = 2;

//on affiche les valeurs de Nombres et de Nombre2 avant permutation
Console.WriteLine("Avant la permutation");
Console.WriteLine($"La valeur de Chaine1 est {Nombre1}");
Console.WriteLine($"La valeur de Chaine2 est {Nombre2}");

//on appelle la procédure Permutation pour effectuer la permutation de la valeur des deux variables
Permutation(ref Nombre1, ref Nombre2);

Console.WriteLine();
//on affiche les valeurs de Nombres et de Nombre2 après permutation
Console.WriteLine("Après la permutation");
Console.WriteLine($"La nouvelle valeur de Chaine1 est {Nombre1}");
Console.WriteLine($"La nouvelle valeur de Chaine2 est {Nombre2}");
