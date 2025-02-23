//https://fr.wikipedia.org/wiki/Tri_par_insertion
//https://fr.wikipedia.org/wiki/Recherche_dichotomique
//11.Recherche dichotomique(optionnel)

//Il s'agit de rechercher la place d'un élément donné dans un tableau.

//Pour cela, on déclarera un tableau d'entiers trié déjà par ordre croissant.
//L'utilisateur entrera l'élément à chercher à la console.

//Le principe
//Au lieu de rechercher séquentiellement du premier jusqu'au dernier, on compare l'élément à chercher à l'élément qui se trouve au milieu du tableau. Si c'est le même, on retourne le rang du milieu sinon on recommence sur la première moitié (ou la deuxième) si l'élément recherché est plus petit (ou plus grand).

//Résultat attendu
//On renvoie le rang (la place) de l'élément s'il est trouvé dans le tableau ou -1 lorsque l'élément n'est pas présent dans le tableau.

int Nombre(string Phrase)
{
    Console.Write(Phrase);
    int Val = int.Parse(Console.ReadLine());

    return Val;
}

const int NbEntiers = 20;
int[] Tableau = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

int Val = Nombre("Quel nombre avez-vous choisi ? ");


//Écriture récursive
//On peut utiliser le pseudo-code suivant2 :
//recherche_dichotomique_récursive(élément, liste_triée):
//   len = longueur de liste_triée;
int Len = NbEntiers;
//m = len / 2;
int Mil = Len / 2;
// trouvé ← faux
bool Trouve = false;


int PositiondeN(Val, int Tableau[], int Debut = 0, int Fin = -1)
{
    //si m<> 0 :
    if (Mil != 0)
    {
        //si liste_triée[m] = élément :
        if (Tableau[Mil] == Val)
        {
            //renvoyer m;
            return Mil;
        }
        //si liste_triée[m] > élément :
        //renvoyer recherche_dichotomique_récursive(élément, liste_triée[1:m - 1]) ;
        else if (Tableau[Mil] > Val)
        {

        }
        //sinon:
        //renvoyer m+recherche_dichotomique_récursive(élément, liste_triée[m + 1:len]);
        else
        {

        }
        //sinon:
        //renvoyer - 1;
    else
        {
            return -1;
        }
    }
}