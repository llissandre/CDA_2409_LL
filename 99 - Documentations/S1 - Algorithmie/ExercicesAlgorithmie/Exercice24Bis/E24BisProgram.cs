//fonction pour demander d'entrer le prix des produits
double PrixProduit(String Phrase)
{
    Console.Write(Phrase);
    double Produits = double.Parse(Console.ReadLine());
    return Produits;
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

string Dixeuros = "10 Euros";
String Cinqeuros = "5 Euros";
string Uneuro = "1 Euros";
String Cinquantecentimes = "50 centimes d'Euro";
String Vingcentimes = "20 centimes d'Euro";
String Dixcentimes = "10 centimes d'Euro";
String Cinqcentimes = "5 centimes d'Euro";
String Deuxcentimes = "2 centimes d'Euro";
String Uncentimes = "1 centimes d'Euro";

int Billets10euros = 0;
int Billets5euros = 0;
int Pieces1euro = 0;

do
{
    Produit = PrixProduit("Entrer le prix des produits : ");
    SommeProduits += Produit;

} while (Produit != 0);

//calculer la somme des achats
Console.WriteLine("La somme des produits : " + SommeProduits + " Euros");
Console.WriteLine($"Vous nous devez {SommeProduits} Euros");

//lire la somme qu'il paie
double Paiement = PaiementClient("\nQuel montant avez-vous payé ?");
Console.WriteLine("Vous avez payé : " + Paiement + " Euros");

//si l'utilisateur ne donne pas assez d'argent
while (SommeProduits > Paiement)
{
    Console.WriteLine($"Ce n'est pas suffisant.\nVous nous devez : {SommeProduits}");
    Console.WriteLine($"Vous avez payé : {Paiement}");
    Paiement = PaiementClient("\nQuel montant avez-vous payé ?");
}

double Sommearendre = (Paiement - SommeProduits);
Console.WriteLine("\nNous vous devons : " + Sommearendre + " Euros\n");

//simuler la remise de la monnaie en affichant les textes "10 Euros", "5 Euros" et "1 Euro" autant de fois qu'il y a de coupures de chaque sorte à rendre
while (Sommearendre >= 1)
{
    if (Sommearendre >= 10)
    {
        Console.Write("10 Euros\n");
        Sommearendre -= 10;
        Billets10euros++;
    }

    else if (Sommearendre >= 5)
    {
        Console.Write("5 Euros\n");
        Sommearendre -= 5;
        Billets5euros++;
    }

    else
    {
        Console.Write("1 Euros\n");
        Sommearendre -= 1;
        Pieces1euro++;
    }
}

Console.WriteLine($"\nNous vous avons donné {Billets10euros} billets de 10 Euros, {Billets5euros} billets de 5 Euros et {Pieces1euro} pièce(s) de 1 Euro");