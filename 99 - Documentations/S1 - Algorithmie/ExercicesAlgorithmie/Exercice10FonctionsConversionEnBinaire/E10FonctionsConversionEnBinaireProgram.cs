//10.Conversion en binaire
//Ecrire et tester une fonction qui convertit un nombre décimal en binaire.

//Exemples :

//2-- > 10
//8-- > 1000
//9-- > 1001
//36-- > 100100
//Ensuite, écrire et  tester une fonction qui transforme un nombre binaire en décimal.


Console.Write("Entrez un nombre : ");
int Entier = int.Parse(Console.ReadLine());
ConversionBinaire(Entier);

string ConversionBinaire(int Entier)
{
    int ResteDivision;
    string Resultat = "";
    int Quotient = Entier;

    while (Quotient != 0)
    {
        Quotient = Math.DivRem(Quotient, 2, out ResteDivision);
        Resultat += ResteDivision;
    }

    string Reverse = "";

    for (int It = Resultat.Length - 1; It >= 0; It--)
    {
        Reverse += Resultat[It];
    }

    Console.WriteLine(Resultat);
    Console.WriteLine($"La conversion binaire de {Entier} est : {Reverse}");

    return Reverse;
}