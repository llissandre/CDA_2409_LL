//11.Inversion de chaine
//Ecrire et tester une fonction Inverse qui prend en paramètre une chaine de caractère et renvoie son inverse.

//Exemple :

//WINDOWS-- > SWODNIW
//KAYAK-- > KAYAK

//Bonus:

//Ecrire et tester une fonction EstPalindrome qui renvoie un booléen égal à true si la chaine est un palindromme.

//C'est quoi un palindrome ?


//on demande à l'utilisateur d'entrer un chaine caractères
Console.Write("Entrez un mot : ");
//Traitement de la chaine entrée
string ChaineEntree = Console.ReadLine();

//si le retour est true on affiche que la chaine de caractères est un palindrome
if (EstPalindrome(ChaineEntree))
{
    Console.WriteLine($"La chaine de caractères {ChaineEntree} est un palindrome");
}

//sinon on affiche que ce n'est pas un palindrome
else
{
    Console.WriteLine($"La chaine de caractères {ChaineEntree} n'est pas un palindrome");
}

//fonction permettant de nous dire si une chaine de caractères est un palindrome ou pas
//retourne un bool
//prend un string en paramètre
bool EstPalindrome(string ChaineAInverser)
{
    //déclaration de la variable ChaineInversee
    string ChaineInversee = "";
    //analyse de la ChaineAInverser
    for (int It = ChaineAInverser.Length; It > 0; It--)
    {
        //inversion des caractères à la volée
        ChaineInversee += ChaineAInverser[It - 1];
    }

    //if (ChaineAInverser == ChaineInversee)
    //on retourne true si les deux chaines de caractères sont égales
    return ChaineAInverser.Equals(ChaineInversee);
}