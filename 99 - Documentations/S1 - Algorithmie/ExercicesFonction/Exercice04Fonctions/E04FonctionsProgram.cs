//Ecrire une fonction Mention qui va renvoyer la mention associée à une note donnée en paramètre.

//Règles d'attribution des mentions :

//16 ou plus : Très Bien
//>= 14 et < 16 : Bien
//>= 12 et < 14 : Assez Bien
//>= 10 et < 12 : Passable
//inférieur à 10 : Echec
//Vous appellerez cette fonction à partir d'un tableau de notes à tester.

//fonction Mention qui renvoie la mention
using System.Globalization;

string Mention(float Note)
{
    if (Note >= 16) { return ("La Mention de la note est Très bien"); }
    else if (Note >= 14) { return ("La Mention de la note est Bien"); }
    else if (Note >= 12) { return ("La Mention de la note est Assez Bien"); }
    else if (Note >= 10) { return ("La Mention de la note est Passable"); }
    else { return ("La Mention de la note est Echec"); }
}

//permet de changer les paramètres locaux de langue de l'ordinateur
CultureInfo ci = new CultureInfo("en-US");
Thread.CurrentThread.CurrentCulture = ci;
Thread.CurrentThread.CurrentUICulture = ci;

//demande à l'utilisateur combien de notes souhaite entrer
Console.Write("Combien de notes souhaitez-vous entrer ? ");
//déclaration et initialisation de la variable NbNotes
int NbNotes = int.Parse(Console.ReadLine());

//création d'un tableau pour ranger les Notes au nombre de NbNotes
float[] Notes = new float[NbNotes];

//boucle tant que l'on n'est pas à la fin du nombre de notes souhaité
for (int Iterateur = 0; Iterateur < Notes.Length; Iterateur++)
{
    //on demande à l'utilisateur d'entrer une note
    Console.Write("Entrez une note : ");
    //on range la note dans le tableau
    Notes[Iterateur] = float.Parse(Console.ReadLine());
    //on appelle la fonction
    //on affiche la mention en fonction de la note entrée
    Console.WriteLine(Mention(Notes[Iterateur]) + "\n");
}
