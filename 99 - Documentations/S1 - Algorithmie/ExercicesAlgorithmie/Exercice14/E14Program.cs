//affiche sur la console : "Entrer le nombre de factures effectuées" 
Console.Write("Entrer le nombre de copies effectuées : ");

//parse la chaine de caractère saisie en un entier "Entier"
double NombreCopies = int.Parse(Console.ReadLine());

//déclaration d'une variable pour le prix d'une photocopie jusqu'à 10 copies
double Dix = 0.1;
//déclaration d'une variable pour le prix d'une photocopie jusqu'à 20 copies
double Vingt = 0.09;
//déclaration d'une variable pour le prix d'une photocopie au-delà
double Audela = 0.08;

//calcul pour le prix des copies jusqu'à 10 copies
if (NombreCopies <= 10)
{
    Console.Write("Vous devez : " + (Dix * NombreCopies) + " Euros");
}
//calcul pour le prix des copies jusqu'à 30 copies
else if (NombreCopies <= 30)
{
    Console.Write("Vous devez : " + ((Dix * 10) + (Vingt * (NombreCopies - 10))) + " Euros");
}
//calcul pour le prix des copies jusqu'à 30 copies
else
{
    Console.Write("Vous devez: " + ((Dix * 10) + (Vingt * 20) + (Audela * (NombreCopies - 30))) + " Euros");
}


// permet de laisser la fenêtre de la console ouverte
Console.ReadLine();