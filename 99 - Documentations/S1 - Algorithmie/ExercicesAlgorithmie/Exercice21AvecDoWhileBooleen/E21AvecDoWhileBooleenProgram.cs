int DemanderNombreEntreUnEtDouze(String Phrase)
{
    Console.Write(Phrase);
    int Mois = int.Parse(Console.ReadLine());

    return Mois;
}

int Mois;
bool Erreur;

//tant que Mois est inférieur à 1 ou supérieur à 12, on demande à l'utilisateur de taper un autre nombre
do
{
    //on demande à l'utilisateur d'entrer un nombre entre 1 et 12
    Mois = DemanderNombreEntreUnEtDouze("Entrez un nombre entre UN et DOUZE : ");
    Erreur = Mois < 1 || Mois > 12;
    if (Erreur)
    {
        Console.WriteLine("Erreur, vous n'avez pas entrer un nombre entre UN et DOUZE ! \nEntrez un nombre entre UN et DOUZE ! \n");
    }
} while (Erreur);

Console.WriteLine($"Bravo ! Vous avez entré '{Mois}', qui est un nombre entre UN et DOUZE !");

// permet de laisser la fenêtre de la console ouverte
Console.ReadLine();