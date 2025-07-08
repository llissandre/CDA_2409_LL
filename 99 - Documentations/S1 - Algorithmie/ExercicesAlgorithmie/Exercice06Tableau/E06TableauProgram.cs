Console.WriteLine("Combien de valeurs souhaitez-vous entrer ? ");
int Valeur = int.Parse(Console.ReadLine());
int NbPositif = 0;
int NbNegatif = 0;

Console.WriteLine();

//un tableau pour ranger les N valeurs
float[] Tableaudevaleurs = new float[Valeur];

//saisir les N valeurs
for (int Iterateur = 0; Iterateur < Tableaudevaleurs.Length; Iterateur++)
{
    Console.Write($"Entrez une valeur n° {Iterateur + 1}: ");
    Tableaudevaleurs[Iterateur] = float.Parse(Console.ReadLine());

    //condition - comparaison
    if (Tableaudevaleurs[Iterateur] < 0)
    //si la valeur est négative
    {
        NbNegatif++;
    }
    //sinon si la valeur est positive
    else
    {
        NbPositif++;
    }
}

//affichage du tableau
Console.Write("\nAffichage du tableau : [");
//Console.Write("[ ");
for (int Iterateur = 0; Iterateur < Tableaudevaleurs.Length; Iterateur++)
{
    Console.Write(Tableaudevaleurs[Iterateur]);
    if (Iterateur != Tableaudevaleurs.Length - 1)
    {
        Console.Write(", ");
    }
}
Console.Write("]\n");

Console.WriteLine("\nLe nombre de valeurs positives est : " + NbPositif);
Console.WriteLine("Le nombre de valeurs négatives est : " + NbNegatif);