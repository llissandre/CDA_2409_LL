//Ecrire une fonction demandant à l'utilisateur d'entrer une réponse de type Oui/Non.
//La fonction renverra la réponse qui sera forcément Oui ou Non.
//La question doit être paramétrable.
//On veut éviter ceci :

//...
//Ecrire "Etes-vous marié ?"
//Rep1 ← ""
//TantQue Rep1<> "Oui" et Rep1 <> "Non"
//  Ecrire "Tapez Oui ou Non"
//  Lire Rep1
//FinTantQue
//...
//Ecrire "Avez-vous des enfants ?"
//Rep2 ← ""
//TantQue Rep2 <> "Oui" et Rep2 <> "Non"
//  Ecrire "Tapez Oui ou Non"
//  Lire Rep2
//FinTantQue

//fonction permettant de demander taper Oui ou Non tant que l'utilisateur ne répond pas Oui ou Non aux questions posées
//retourne un string
//prend un string en paramètre
void Reponse(string Question)
{
    //écris la question
    Console.WriteLine(Question);
    //traite la réponse
    string? Reponse = Console.ReadLine();

    //boucle tant que l'utilateur ne tape pas Oui ou Non (et ...)
    do
    {
        Console.WriteLine("Répondez Oui ou Non aux questions : ");
        Reponse = Console.ReadLine();
    } while (Reponse != "Oui" && Reponse != "Non" && Reponse != "O" && Reponse != "N" & Reponse != "o" && Reponse != "n");

    Console.WriteLine($"Bien, vous avez répondu {Reponse} !!!");
}


//appel de la fonction Reponse pour poser une question et attendre la réponse Oui ou Non de l'utilisateur
Reponse("Êtes-vous marié ?");

//appel de la fonction Reponse pour poser une question et attendre la réponse Oui ou Non de l'utilisateur
Reponse("\nAvez-vous des enfants ?");