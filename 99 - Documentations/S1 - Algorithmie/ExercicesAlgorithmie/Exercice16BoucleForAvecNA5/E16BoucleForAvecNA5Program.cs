//On définit N à 5
int N = 5;
int Somme = 0;

for (int Iterateur = N; Iterateur > 0; Iterateur--)
{
    Somme += Iterateur;
}

Console.WriteLine($"La somme des {N} entiers inférieurs ou égaux à n est : {Somme}");

// permet de laisser la fenêtre de la console ouverte
Console.ReadLine();