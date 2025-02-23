//13.Code cesar
//Principe
//Le chiffrement par décalage, connu comme le chiffre de César ou le code de César, est une méthode de chiffrement très simple utilisée par Jules César dans ses correspondances secrètes.

//Le texte chiffré s'obtient en remplaçant chaque lettre du texte clair original par une lettre à distance fixe, toujours du même côté, dans l'ordre de l'alphabet. Pour les dernières lettres (dans le cas d'un décalage à droite), on reprend au début.

//Par exemple avec un décalage de 3 vers la droite, A est remplacé par D, B devient E, et ainsi jusqu'à W qui devient Z, puis X devient A etc.
//Les caractères espace du texte en clair sont laissés tels quels dans le texte chiffré.

//La longueur du décalage, 3 dans l'exemple évoqué, constitue la clé du chiffrement qu'il suffit de transmettre au destinataire pour que celui-ci puisse déchiffrer le message.

//Etape 1
//Ecrire et tester une méthode qui permet de chiffrer un message avec le code de César.

//Etape 2
//Proposer une nouvelle version qui permet de paramétrer le sens (à Droite ou à Gauche) dans lequel s'effectue le décalage. Par défaut, le décalage s'effectuera vers la droite.

//Chiffrement vs cryptage : quelles différences ?
//https://www.primx.eu/fr/abc-chiffrement/chiffrement-vs-cryptage-quelles-differences/

//la table ASCII
//https://fr.wikibooks.org/wiki/Les_ASCII_de_0_%C3%A0_127/La_table_ASCII



//fonction permettant de demander d'entrer un texte
//Retourne le texte entré
//Retourne un string
//Prend un string en paramètre
string Question(string Phrase)
{
    string Message;
    //permet de poser la question tant que la réponse est vide
    do
    {
        Console.Write(Phrase);
        Message = Console.ReadLine();
    } while (Message == null || Message == "");
    return Message;
}

//fonction permettant de taper le décalage souhaité
//Retourne un entier
//Prend un string en paramètre
int Decalagesouhaite(string Phrase)
{
    //déclaration de l'entier Decalagesouhaite
    int Decalage;
    //déclaration du booléen ParseOK
    bool ParseOK;

    //boucle pour gérer si on tape autre chose qu'un entier
    do
    {
        Console.Write(Phrase);
        //boucle do - while
        //fait le tryparse tant que ParseOK est false
        //si le TryParse se fait, true, renvoie de Decalagesouhaite
        ParseOK = int.TryParse(Console.ReadLine(), out Decalage);
    } while (ParseOK == false);

    //renvoi la valeur donnée à la variable DemandeNombre
    return Decalage;
}

//Fonction permettant d'indiquer si on souhaite chiffrer ou déchiffrer un document
//Retourne un booléen
//Prend un string en paramètre
bool Dechiffrage(string Phrase)
{
    //déclaration de la variable Demande;
    string Demande;

    //permet de poser la question tant que la réponse est vide
    do
    {
        Console.Write(Phrase);
        Demande = Console.ReadLine();
    } while (Demande == null || Demande == "");
    if (Demande == "O" || Demande == "o")
    {
        return true;
    }
    return false;
}

//Fonction permettant de chiffrer ou de déchiffrer un message
//Retourne un string
//Prend un string, un entier et un booléen en paramètre
string CodeCesar(string MessageRecu, int Cle, bool Dechiffrage)
{
    //initialisation de la variable qui reçoit le message déchiffré lettre par lettre
    string Resultat = "";

    //Boucle pour traiter le message dans son ensemble
    for (int It = 0; It < MessageRecu.Length; It++)
    {
        if (MessageRecu[It] == ' ')//le caractère espace est laissé tel quel
        {
            Resultat += ' ';
        }
        else
        {
            //déclaration et initialisation de la variable qui permet de savoir si le caractère est écrit en minuscule ou en majuscule
            bool Maj = char.IsUpper(MessageRecu[It]);

            //déclaration de la variable Caractere qui permet de manipuler le caractère pour le chiffrage ou le déchiffrage
            int Caractere;

            //condition et traitement si la valeur de la Clé est supérieure à 26
            Cle %= 26;
            //if (Cle > 26)
            //{
            //    do
            //    {
            //        Cle -= 26;
            //    }
            //    while (Cle > 26);
            //}

            //on attribue la valeur décimale du caractère traité du message reçu
            //si on veut chiffrer
            //on ajoute à caractère la valeur du décalage souhaité
            if (!Dechiffrage)
            {
                Caractere = (int)MessageRecu[It] + Cle;
            }
            //sinon si on veut déchiffrer
            //on retire à la valeur décimale du caractère la valeur du décalage souhaité
            else
            {
                Caractere = (int)MessageRecu[It] - Cle;
            }

            //si on souhaite chiffrer que le caractère est majuscule et que sa valeur est supérieure à 90 (Z) ou que le caractère est  minuscule et que sa valeur est supérieure à 122 (z)
            //on retire 26 à Caractere pour revenir au début de l'alphabet
            if ((Caractere > 90 && Maj || Caractere > 122 && !Maj) && !Dechiffrage)
            {
                Caractere -= 26;
            }
            //si on souhaite déchiffrer que le caractère est majuscule et que sa valeur est inférieure à 65 (A) ou que le caractère est  minuscule et que sa valeur est inférieure à 122 (a)
            //on ajoute 26 pour revenir à la fin de l'alphabet
            if ((Caractere < 65 && Maj || Caractere < 97 && !Maj) && Dechiffrage)
            {
                Caractere += 26;
            }

            //à chaque tour de boucle, on attribue à Resultat le caractère traité après son décalage
            Resultat += (char)Caractere;
        }
    }

    //à la fin du traitement, on retourne la valeur de Resultat
    return Resultat;
}

//l'utilisateur doit taper son message
string Message = Question("Tapez votre message : ");

//initialisation de la variable Chiffrage pour savoir si on chiffre ou si on déchiffre
bool DeChiffrage = Dechiffrage("Voulez-vous déchiffrer ? : ");

//intialisation de la variable Cle pour le décalage souhaité
int Cle = Decalagesouhaite("Quel est le décalage souhaité ? : ");

//déclaration et initialisation de la variable ResultatTraitemen
string ResultatTraitement = CodeCesar(Message, Cle, DeChiffrage);

//affichage du message chiffré
Console.WriteLine($"Votre message traité est : {ResultatTraitement}");