//Ecrire une procédure pour dire bonjour à une personne.
//Le nom de la personne sera passé en paramètre.
//L'affichage se fera à la console.

//Tester l'appel de la procédure dans un Main.

void DireBonjour(string Prenom, string Nom)
{
    Console.WriteLine($"Bonjour {Prenom} {Nom} !");
}

string DemanderPrenomNom(string Phrase)
{
    Console.Write(Phrase);
    string? Valeur;
    do
    {
        Valeur = Console.ReadLine(); 
    } while (Valeur == null || Valeur == "");

    return Valeur;
}


string Prenom = DemanderPrenomNom("Écris ton Prénom : ");
string Nom = DemanderPrenomNom("Écris ton Nom : ");

DireBonjour(Prenom, Nom);
