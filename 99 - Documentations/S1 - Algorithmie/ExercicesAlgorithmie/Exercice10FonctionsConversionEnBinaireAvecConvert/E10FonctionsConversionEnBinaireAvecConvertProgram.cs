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
    string Binaire = Convert.ToString(Entier, 2);
    Console.WriteLine($"La conversion binaire de {Entier} est : {Binaire}");

    return Binaire;
}