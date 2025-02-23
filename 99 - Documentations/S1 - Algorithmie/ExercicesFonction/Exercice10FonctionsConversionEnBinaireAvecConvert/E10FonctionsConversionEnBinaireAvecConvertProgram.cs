//10.Conversion en binaire
//Ecrire et tester une fonction qui convertit un nombre décimal en binaire.

//Exemples :

//2-- > 10
//8-- > 1000
//9-- > 1001
//36-- > 100100
//Ensuite, écrire et  tester une fonction qui transforme un nombre binaire en décimal.


//déclaration de l'entier DemandeNombre
int Entier;
//déclaration du booléen ParseOK
bool ParseOk;
do
{
    //boucle do - while
    //fait le tryparse tant que ParseOK est false
    //si le TryParse se fait, true, renvoie de DemandeNombre
    Console.Write("Entrez un nombre : ");
    ParseOk = int.TryParse(Console.ReadLine(), out Entier);

} while (ParseOk == false);

Console.WriteLine($"La conversion binaire de {Entier} est : {ConversionBinaire(Entier)}");

//fonction permettant de convertir un décimal en binaire
//retourne un string
//prend un entier en paramètre
string ConversionBinaire(int Entier)
{
    //utilisation de la fonction Convert
    string Binaire = Convert.ToString(Entier, 2);
    //retourne l'entier converti en binaire
    return Binaire;
}