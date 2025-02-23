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
int[] Tableau = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 110, 120, 130, 140, 150, 160, 170, 180, 190, 200 };

//Écriture itérative

//L'algorithme de dichotomie permettant de trouver une valeur val dans un tableau t de N+1 entiers trié par ordre croissant est le suivant :
////déclarations
// début, fin, val, mil, N
// t : Tableau[0..N] d 'entiers classé
// trouvé: Booléen
// //initialisation
int Mil = 0;
// début ← 0
int Debut = 0;

// trouvé ← faux
bool Trouve = false;

int Compteur = 0;

int Val = Nombre("Quel nombre avez-vous choisi ? ");

// fin ← N
int Fin = NbEntiers;

while (!Trouve && Debut <= Fin)
{
    Compteur++;

    Mil = (Debut + Fin) / 2;
    if (Tableau[Mil] == Val)
    {
        Trouve = true;
    }
    else if (Val > Tableau[Mil])
    {
        Debut = Mil + 1;
    }
    else
    {
        Fin = Mil - 1;
    }
}

if (Trouve == true)
{
    Console.WriteLine($"La valeur est {Val}, au rang {Mil}");
}
else
{
    Console.WriteLine("La valeur n'est pas dans le tableau");
}

Console.WriteLine("Nombre de coups pour avoir trouver le nombre juste : " + Compteur);

////Boucle de recherche
// // La condition début inférieur ou égal à fin permet d'éviter de faire une boucle infinie si 'val' n'existe pas dans le tableau.
//
//  Tant que trouvé != vrai et début <= fin:
//      mil ← partie_entière((début + fin) / 2)
//      si t[mil] == val:
//         trouvé ← vrai
//      sinon:
//         si val > t[mil]:
//            début ← mil + 1
//         sinon:
//            fin ← mil - 1
//
// //Affichage du résultat
//  Si trouvé == vrai:
//      Afficher "La valeur ", val , " est au rang ", mil
//  Sinon:
//      Afficher "La valeur ", val , " n'est pas dans le tableau"