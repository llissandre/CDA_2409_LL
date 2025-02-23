//fonction pour demander d'entrer le prix des produits
double PrixProduit(String Phrase)
{
    Console.Write(Phrase);
    double Produit = double.Parse(Console.ReadLine());

    return Produit;
}

//fonction pour lire la somme payee
double PaiementClient(String Phrase)
{
    Console.Write(Phrase);
    double Paiement = double.Parse(Console.ReadLine());

    return Paiement;
}

//lire la suite des prix
double SommeProduits = 0;
double Produit = 0;

string dix = "10 Euros";
String cinq = "5 Euros";
string un = "1 Euros";

do
{
    Produit = PrixProduit("Entrer le prix des produits : ");
    SommeProduits += Produit;

} while (Produit != 0);

//calculer la somme des achats
Console.WriteLine("La somme des produits : " + SommeProduits + " Euros");

//lire la somme qu'il paie
double Paiement = PaiementClient("\nQuel montant avez-vous payé ?");
Console.WriteLine("Vous avez payé : " + Paiement + " Euros");

double Sommearendre = (Paiement - SommeProduits);
Console.WriteLine("\nNous vous devons : " + Sommearendre + " Euros\n");

//simuler la remise de la monnaie en affichant les textes "10 Euros", "5 Euros" et "1 Euro" autant de fois qu'il y a de coupures de chaque sorte à rendre
while (Sommearendre > 1)
{
    if (Sommearendre >= 10)
    {
        Console.Write("10 Euros\n");
        Sommearendre -= 10;
    }

    else if (Sommearendre >= 5)
    {
        Console.Write("5 Euros\n");
        Sommearendre -= 5;
    }

    else
    {
        Console.Write("1 Euros");
        Sommearendre -= 1;
    }
}