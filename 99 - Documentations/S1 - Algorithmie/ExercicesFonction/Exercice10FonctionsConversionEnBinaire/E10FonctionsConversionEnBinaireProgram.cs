//10.Conversion en binaire
//Ecrire et tester une fonction qui convertit un nombre décimal en binaire.

//Exemples :

//2-- > 10
//8-- > 1000
//9-- > 1001
//36-- > 100100
//Ensuite, écrire et  tester une fonction qui transforme un nombre binaire en décimal.


// déclaration de l'entier DemandeNombre
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

//on affiche la conversion de l'entier
Console.WriteLine($"La conversion binaire de {Entier} est : {ConversionBinaire(Entier)}");


//fonction permettant de convertir un décimal en binaire
//retourne un string
//prend un entier en paramètre
string ConversionBinaire(int Entier)
{
    //déclaration de ResteDivision
    int ResteDivision;
    //déclaration de Resultat
    string Resultat = "";
    //déclaration et initialisation de Quotient à Entier
    int Quotient = Entier;

    //tant que la valeur de la variable Quotient est différente de 0
    while (Quotient != 0)
    {
        //on divise par deux le quotient
        Quotient = Math.DivRem(Quotient, 2, out ResteDivision);
        //et on affecte le reste de la division à Resultat
        Resultat += ResteDivision;
    }

    //Resultat a le resultat de la conversion mais à l'envers
    //déclaration de Reverse
    string Reverse = "";

    //on assigne à It la taille du tableau-1
    //on décrémente It jusqu'à ce que It soit supérieur ou égal à 0
    //ce qui permet de parcourir tout le tableau
    for (int It = Resultat.Length - 1; It >= 0; It--)
    {
        //on verse le contenu de Resulat
        Reverse += Resultat[It];
    }

    //on retourne le Reverse
    return Reverse;
}