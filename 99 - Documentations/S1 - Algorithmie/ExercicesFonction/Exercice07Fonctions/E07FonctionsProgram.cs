//7.Affichage d 'un tableau
//Reprendre l'exercice Somme de 2 tableaux.

//Ecrire une procédure pour afficher le contenu d'un tableau à la console et l'appeler pour afficher les 2 tableaux initiaux et le tableau résultant.

//int[] Tableau1 = new int[Nombredevaleur];
//int[] Tableau2 = new int[Nombredevaleur];

//déclaration et initialisation des valeurs dans le tableau1
int[] Tableau1 = { 1, 2, 3, 4, 5, 6, 7, 8 };
//déclaration et initialisation des valeurs dans le tableau2
int[] Tableau2 = { 9, 10, 11, 12, 13, 14, 15, 16 };

//Procédure pour affichage du contenu d'un tableau
static void AffichageTableau(int[] ContenuTableau, string Nomdutableau)
{
    //boucle qui permet de parcourir tout le tableau
    for (int Iterateur = 0; Iterateur < ContenuTableau.Length; Iterateur++)
    {
        //afficher le contenu du tableau ligne par ligne
        //Console.WriteLine($"La contenu du tableau à la position {Iterateur + 1} est : {(ContenuTableau[Iterateur])}");

        //afficher le nom du tableau
        if (Iterateur == 0) { Console.WriteLine($"\n{Nomdutableau}"); }
        //afficher le premier crocher
        if (Iterateur == 0) { Console.Write("["); }

        //afficher le contenu du tableau sur une seule ligne entre crochets
        Console.Write(ContenuTableau[Iterateur]);
        //mettre une virgule entre chaque valeur du tableau
        if (Iterateur != ContenuTableau.Length - 1) { Console.Write(", "); }
    }
    //afficher le deuxième crochet à la fin du tableau
    Console.Write("]\n");
}

//appel de la procédure pour afficher le nom du tableau et le contenu du tableau 1 sur une seule ligne entre crochets
AffichageTableau(Tableau1, "Tableau1");

//appel de la procédure pour afficher le nom du tableau et le contenu du tableau 2 sur une seule ligne entre crochets
AffichageTableau(Tableau2, "Tableau2");

//déclaration et initialisation de Tableau3
int[] Tableau3 = new int[Tableau1.Length];

//boucle qui parcourt tout le tableau3 pour assigner à chaque emplacement la somme du tableau1 et du Tableau2
for (int Iterateur = 0; Iterateur < Tableau3.Length; Iterateur++)
{
    Tableau3[Iterateur] = Tableau1[Iterateur] + Tableau2[Iterateur];
}

//appel de la procédure pour afficher le nom du tableau et le contenu du tableau 3 sur une seule ligne entre crochets
AffichageTableau(Tableau3, "Tableau3");