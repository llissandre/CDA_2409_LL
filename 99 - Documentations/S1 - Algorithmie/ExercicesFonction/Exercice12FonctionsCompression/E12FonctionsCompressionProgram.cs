//12.Compression
//Ecrire et tester une fonction de compression.
//On remplace plusieurs caractères consécutifs de la manière suivante :

//AAAaa-- > 3A2a
//ABC --> ABC
//AAAAABBBCC --> 5A3B2C


//Console.Write("Entrez une série de caractères : ");
//string Texte = Console.ReadLine();
//Compression(Texte);

////string Chaine1 = "AAaDDfffF";

//demande à l'utilisateur d'entrer une série de caractères
Console.Write("Entrez une série de caractères : ");
//déclaration et initialisation de la variable Texte par la chaine de caractère entrée par l'utilisateur
string? Texte = Console.ReadLine();


//appel de la procédure pour compresser une chaine de caractère, la chaine de caractères en paramètre
//afficher 
Console.WriteLine("La compression du texte saisi est : " + Compression(Texte));

//procédure compression de caractères
//la chaine de caractère, le message à compresser, en paramètre
string Compression(string ChaineACompresser)
{
    //déclaration et initialisation de la chaine de caractère qui recevra la chaine de caractères compressée
    string ChaineCompressee = "";
    //déclaration et initialisation de l'itérateur qui permettra de comptabiliser le nombre de caractères qui se suivent
    int CompteurDeCaracteres = 1;

    //boucle pour parcourir toute la chaine de caractères
    for (int It = 0; It < ChaineACompresser.Length; It++)
    {
        //comparaison
        //on compare la valeur de la variable It1 à la taille du tableau
        //si la valeau de la variable It1 est infèrieure à la taille du tableau -1
        if (It < ChaineACompresser.Length - 1)
        {
            //condition qui permet d'analyser deux caractères qui se suivent
            //si les deux caractères se suivent, un itérateur s'incrémente pour comptabiliser le nombre de caractères qui suivent
            if (ChaineACompresser[It] == ChaineACompresser[It + 1])
            {
                //l'itérateur CompteurDeCaracteres s'incrémente tant que les caractères se suivent
                CompteurDeCaracteres++;
            }

            //Si les deux caractères ne sont pas identiques
            else
            {
                //condition pour ne pas afficher la valeur de la variable CompteurDeCaracteres quand elle est égale à 1 devant le caractère
                if (CompteurDeCaracteres == 1)
                {
                    //ajout du caractère sans le CompteurDeCaracteres
                    ChaineCompressee += ChaineACompresser[It];
                }

                //sinon
                else
                {
                    //ajout de la variable Compteur à ChaineCompressee puis de la variable ChaineACompresser
                    //la variable CompteurDeCaracteres contient le nombre de caractères qui se suivent
                    //la variable ChaineACompresser contient le caractère comparé
                    //ToString() permet de retourner CompteurDeCaracteres en chaine de caractères
                    ChaineCompressee += CompteurDeCaracteres.ToString() + ChaineACompresser[It];

                    //ajout du caractère situé à la position ChaineACompresser[It] à ChaineCompressee
                    //ChaineCompressee += ChaineACompresser[It];

                    //réinitialisation de la variable CompteurDeCaracteres à 1 pour permettre de comptabiliser combien de fois les caractères suivants sont identiques
                    CompteurDeCaracteres = 1;
                }
            }
        }

        //sinon (c.a.d : traitement du dernier caractère)
        else
        {
            //condition pour ne pas afficher la valeur de la variable CompteurDeCaracteres quand elle est égale à 1 devant le caractère
            if (CompteurDeCaracteres == 1)
            {
                //ajout du caractère sans le CompteurDeCaracteres
                ChaineCompressee += ChaineACompresser[It];
            }
            //sinon
            else
            {
                //ajout de la variable Compteur à ChaineCompressee puis de la variable ChaineACompresser
                //la variable CompteurDeCaracteres contient le nombre de caractères qui se suivent
                //la variable ChaineACompresser contient le caractère comparé
                //ToString() permet de retourner CompteurDeCaracteres en chaine de caractères
                ChaineCompressee += CompteurDeCaracteres.ToString() + ChaineACompresser[It];

                //ChaineCompressee += ChaineACompresser[It];
            }
        }
    }
    //retour de la valeur de la chaine de caractères ChaineCompressee
    return ChaineCompressee;
}