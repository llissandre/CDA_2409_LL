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



//Etape 2
Console.Write("Écrivez votre message : ");
string Message = Console.ReadLine();
CodeCesarEtape2(Message);

void CodeCesarEtape2(string MessageFct)
{
    Console.WriteLine("Dans quel sens souhaitez-vous que le décalage s'opère (D/G) ?");
    string Choix = Console.ReadLine();

    string MessageRecu = "";

    for (int It = 0; It < MessageFct.Length; It++)
    {
        if (Choix == "D")
        {
            char Caractere = MessageFct[It];
            if (Caractere == 90)
            {
                Caractere = (char)((int)Caractere - 26 + 1);
            }
            else if (Caractere == 122)
            {
                Caractere = (char)((int)Caractere - 26 + 1);
            }
            else
            {
                Caractere = (char)((int)Caractere + 1);
            }
            MessageRecu += Caractere;
        }
        else
        {
            char Caractere = MessageFct[It];
            if (Caractere == 65)
            {
                Caractere = (char)((int)Caractere + 26 - 1);
            }
            else if (Caractere == 97)
            {
                Caractere = (char)((int)Caractere + 26 - 1);
            }
            else
            {
                Caractere = (char)((int)Caractere - 1);
            }
            MessageRecu += Caractere;
        }
    }
    Console.Write($"Votre message reçu sera : {MessageRecu}");
}