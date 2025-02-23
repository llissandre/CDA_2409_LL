//n est fixé à 5
int n = 5;

int Somme = 0;
int Iterateur = 1;

while (Iterateur <= n)
{
    Somme += Iterateur;
    Iterateur++;
}

Console.WriteLine("La somme des n entiers inférieurs ou égaux à n est : " + Somme);

// permet de laisser la fenêtre de la console ouverte
Console.ReadLine();