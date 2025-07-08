//11.Inversion de chaine
//Ecrire et tester une fonction Inverse qui prend en paramètre une chaine de caractère et renvoie son inverse.

//Exemple :

//WINDOWS-- > SWODNIW
//KAYAK-- > KAYAK


//on demande à l'utilisateur d'entrer un chaine caractères
Console.Write("Entrez un mot : ");
//Traitement de la chaine entrée
string Chainedecaracteresavantinversion = Console.ReadLine();
//affichage de la chaine entrée
Console.WriteLine($"La chaine de caractères entrés par l'utilisateur est : {Chainedecaracteresavantinversion}");
//déclaration et initialisation de la variable Chainedecaracteresapresinversion
//appel de la fonction
string Chainedecaracteresapresinversion = InversionDeChaine(Chainedecaracteresavantinversion);
//affichage de la chaine de caractères après inversion
Console.WriteLine($"La chaine de caractères après inversion est : {Chainedecaracteresapresinversion}");

//fonction permettant d'inverser une chaine de caractères
//retourne un string
//prend un string en paramètre
string InversionDeChaine(string ChaineAInverser)
{
    //déclaration de la variable ChaineInversee
    string ChaineInversee = "";
    //analyse de la ChaineAInverser
    for (int It = ChaineAInverser.Length; It > 0; It--)
    {
        //inversion des caractères à la volée
        ChaineInversee += ChaineAInverser[It - 1];
    }
    //retour de la chaine de caractères inversée
    return ChaineInversee;
}