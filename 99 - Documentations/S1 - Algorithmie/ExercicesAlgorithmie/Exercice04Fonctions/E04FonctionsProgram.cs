//Ecrire une fonction Mention qui va renvoyer la mention associée à une note donnée en paramètre.

//Règles d'attribution des mentions :

//16 ou plus : Très Bien
//>= 14 et < 16 : Bien
//>= 12 et < 14 : Assez Bien
//>= 10 et < 12 : Passable
//inférieur à 10 : Echec
//Vous appellerez cette fonction à partir d'un tableau de notes à tester.

//fonction Mention
string Mention(float Note)
{
    if (Note >= 16) { return ("La Mention de la note est Très bien"); }
    else if (Note >= 14) { return ("La Mention de la note est Bien"); }
    else if (Note >= 12) { return ("La Mention de la note est Assez Bien"); }
    else if (Note >= 10) { return ("La Mention de la note est Passable"); }
    else { return ("La Mention de la note est Echec"); }
}

Console.Write("Combien de notes souhaitez-vous entrer ? ");
int NbNotes = int.Parse(Console.ReadLine());

//un tableau pour ranger les Notes au nombre de NbNotes
float[] Notes = new float[NbNotes];

//saisir les N valeurs
for (int Iterateur = 0; Iterateur < Notes.Length; Iterateur++)
{
    Console.Write("Entrez une note : ");
    Notes[Iterateur] = float.Parse(Console.ReadLine());
    Console.WriteLine(Mention(Notes[Iterateur]));
}
