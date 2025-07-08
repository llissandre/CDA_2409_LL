//11.Inversion de chaine
//Ecrire et tester une fonction Inverse qui prend en paramètre une chaine de caractère et renvoie son inverse.

//Exemple :

//WINDOWS-- > SWODNIW
//KAYAK-- > KAYAK

//Bonus:

//Ecrire et tester une fonction EstPalindrome qui renvoie un booléen égal à true si la chaine est un palindromme.

//C'est quoi un palindrome ?

Console.Write("Entrez un mot : ");
string C1 = Console.ReadLine();
InversionDeChaine(C1);


void InversionDeChaine(string Chaine)
{
    char[] Chaine1 = Chaine.ToCharArray();

    for (int It1 = 0; It1 < (Chaine.Length) / 2; It1++)
    {
        Char Temp = Chaine1[It1];
        Chaine1[It1] = Chaine1[Chaine.Length - It1 - 1];
        Chaine1[Chaine.Length - It1 - 1] = Temp;
    }
    Console.WriteLine(Chaine1);
}