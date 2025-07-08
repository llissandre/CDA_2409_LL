//Ecrire et tester une fonction qui calcule la distance AB entre 2 points A (x1, y1) et B(x2, y2).

//Vous vérifierez notamment que la distance entre A et B est la même que la distance entre B et A.

//Math.Sqrt calcule la racine carrée d'un nombre
//d(A, B) = Racine carrée de (x2-x1) au carré + (y2-y1) au carré

//fonction pour calculer la distance entre deux points
float Distanceentredeuxpoints(float x1, float x2, float y1, float y2)
{
    float DistanceaucarreAB = Convert.ToSingle(Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1))));
    return DistanceaucarreAB;
}

//valeur des points
float x1 = 1;
float x2 = 100;
float y1 = 1;
float y2 = 1;

//calcul de la distance de A à B
float DistanceaucarreAB = Distanceentredeuxpoints(x1, x2, y1, y2);
//calcul de la distance de B à A
float DistanceaucarreBA = Distanceentredeuxpoints(x2, x1, y2, y1);
//affichage des calculs
Console.WriteLine("La distance entre A et B est : " + DistanceaucarreAB);
Console.WriteLine("La distance entre B et A est : " + DistanceaucarreBA);