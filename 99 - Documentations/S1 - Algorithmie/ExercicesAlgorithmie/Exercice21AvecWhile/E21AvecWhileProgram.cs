int DemanderNombreEntreUnEtDouze(String Phrase)
{
    Console.Write(Phrase);
    int Mois = int.Parse(Console.ReadLine());

    return Mois;
}

//on demande à l'utilisateur d'entrer un nombre entre 1 et 12
int Mois = DemanderNombreEntreUnEtDouze("Entrez un nombre entre UN et DOUZE : ");

//tant que Mois est inférieur à 1 ou supérieur à 12, on demande à l'utilisateur de taper un autre nombre
while (Mois < 1 || Mois > 12)
{
    Console.WriteLine("Erreur, vous n'avez pas entrer un nombre entre UN et DOUZE ! \nEntrez un nombre entre UN et DOUZE ! \n");

    Mois = DemanderNombreEntreUnEtDouze("Entrez un nombre entre UN et DOUZE : ");
}

Console.WriteLine($"Bravo ! Vous avez entré '{Mois} qui n'est pas un nombre entre UN et DOUZE !");

// permet de laisser la fenêtre de la console ouverte
Console.ReadLine();