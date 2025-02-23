//12.Compression
//Ecrire et tester une fonction de compression.
//On remplace plusieurs caractères consécutifs de la manière suivante :

//AAAaa-- > 3A2a
//ABC --> ABC
//AAAAABBBCC --> 5A3B2C


//Console.Write("Entrez une série de caractères : ");
//string Texte = Console.ReadLine();
//Compression(Texte);

////string Chaine1 = "AAaDDfffF";


Console.Write("Entrez une série de caractères : ");
string Texte = Console.ReadLine();
Compression(Texte);

void Compression(string Chaine1)
{
    string Chaine2 = "";
    int It2 = 1;

    for (int It1 = 0; It1 < Chaine1.Length; It1++)
    {
        if (It1 < Chaine1.Length - 1)
        {
            if (Chaine1[It1] == Chaine1[It1 + 1])
            {
                It2++;
            }

            else
            {
                Chaine2 += It2;
                Chaine2 += Chaine1[It1];
                It2 = 1;
            }
        }
        else
        {
            Chaine2 += It2;
            Chaine2 += Chaine1[It1];
        }
    }

    Console.WriteLine("La compression du texte saisi est : " + Chaine2);
}