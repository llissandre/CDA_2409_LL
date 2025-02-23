//affiche sur la console : "Entrer le nombre de factures effectuées" 
Console.Write("Entrer le nombre de copies effectuées : ");

//parse la chaine de caractère saisie en un entier "Entier"
double NombreCopies = int.Parse(Console.ReadLine());

//déclaration d'une variable pour stocker le prix 
double Prix = 0;

//calcul pour le prix des copies jusqu'à 10 copies
if (NombreCopies <= 10)
{
    Prix = NombreCopies * 0.1;
    Console.Write("Vous devez : " + Prix + "€ \n");
}
//calcul pour le prix des copies jusqu'à 30 copies
else if (NombreCopies <= 30)
{
    Prix = 1 + 0.09 * (NombreCopies - 10);
    Console.Write("Vous devez : " + Prix + " €\n");
}
//calcul pour le prix des copies jusqu'à 30 copies
else
{
    Prix = 2.8 + 0.08 * (NombreCopies - 30);
    Console.Write("Vous devez: " + Prix + " €\n");
}


// permet de laisser la fenêtre de la console ouverte
Console.ReadLine();