//affiche sur la console : "Quelle est votre ancienneté dans la compagnie ?"
Console.Write("Entrez un nombre : ");

//récupère l'âge donné par l'utilisateur et le range dans la 
//variable Age
int Nombre = int.Parse(Console.ReadLine());
int Iterateur = 1;

while (Iterateur <= 10)
{
    Console.WriteLine($"{Nombre} x {Iterateur} = {Nombre * Iterateur}");
    Iterateur++;
}

// permet de laisser la fenêtre de la console ouverte
Console.ReadLine();