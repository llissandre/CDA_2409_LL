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


string Reponse(string Question)
{
    Console.WriteLine(Question);
    string Reponse = Console.ReadLine();

    while (Reponse != "Oui" && Reponse != "Non")
    {
        Console.WriteLine("Tapez Oui ou Non");
        Reponse = Console.ReadLine();
    }
    Console.WriteLine($"Bien, vous avez répondu {Reponse} !!!");
    return Reponse;
}

Reponse("Êtes-vous marié ? Oui/Non");

Reponse("\nAvez-vous des enfants ? Oui/Non");

