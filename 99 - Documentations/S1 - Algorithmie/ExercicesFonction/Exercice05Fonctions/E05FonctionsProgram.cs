//Ecrire et tester une fonction qui calcule la distance AB entre 2 points A (x1, y1) et B(x2, y2).

//Vous vérifierez notamment que la distance entre A et B est la même que la distance entre B et A.

//Math.Sqrt calcule la racine carrée d'un nombre
//d(A, B) = Racine carrée de (x2-x1) au carré + (y2-y1) au carré

//fonction pour calculer la distance entre deux points
double DistanceEntreDeuxPoints(double x1, double x2, double y1, double y2)
{
    //Plusieurs solutions pour effectuer le calcul :

    //float DistanceaucarreAB = Convert.ToSingle(Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1))));
    double Tmp = Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2);
    //double DistanceaucarreAB = (Math.Sqrt(Tmp));
    //return DistanceaucarreAB;
    return Math.Sqrt(Tmp);
}

//déclaration et initialisation de la valeur des variables, avec la valeur de chaque point
double xA = 12.6;
double xB = -5.34;
double yA = 74.2;
double yB = 1;

//calcul de la distance de A à B
double DistanceaucarreAB = DistanceEntreDeuxPoints(xA, yA, xB, yB);
//affichage des calculs
Console.WriteLine("La distance entre A et B est : " + DistanceaucarreAB);
//calcul de la distance de B à A
double DistanceaucarreBA = DistanceEntreDeuxPoints(xB, yB, xA, yA);
//affichage des calculs
Console.WriteLine("La distance entre B et A est : " + DistanceaucarreBA);

//condition qui renvoie la phrase si les distances sont égales
if (DistanceaucarreAB == DistanceaucarreBA)
{
    Console.WriteLine("\nLes deux distances sont bien égales");
}