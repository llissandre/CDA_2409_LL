//9.Permutation
//Ecrire et tester une fonction qui permute les valeurs de 2 chaines de caractères.



void Permutation(ref string Valeur1, ref string Valeur2)
{
    String Temp = Valeur1;
    Valeur1 = Valeur2;
    Valeur2 = Temp;
}

//void Permutation2(string Valeur1, string Valeur2)
//{
//    String Temp = Valeur1;
//    Valeur1 = Valeur2;
//    Valeur2 = Temp;
//}

string C1 = "LaValeurDeC1";
String C2 = "LaValeurDeC2";

Console.WriteLine($"La valeur de C1 est {C1}");
Console.WriteLine($"La valeur de C2 est {C2}");

Permutation(ref C1, ref C2);

Console.WriteLine();
Console.WriteLine($"La nouvelle valeur de C1 est {C1}");
Console.WriteLine($"La nouvelle valeur de C2 est {C2}");

//string C3 = "LaValeurDeC3";
//String C4 = "LaValeurDeC4";

//Console.WriteLine($"La valeur de C3 est {C3}");
//Console.WriteLine($"La valeur de C4 est {C4}");

//Permutation2(C3, C4);

//Console.WriteLine();
//Console.WriteLine($"La nouvelle valeur de C3 est {C3}");
//Console.WriteLine($"La nouvelle valeur de C4 est {C4}");