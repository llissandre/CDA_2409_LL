//affiche sur la console : "Rentrez un rayon :"
Console.WriteLine("Rentrez un rayon :");

//récupère le nombre donné par l'utilisateur et le
//range dans la variable R
String R = Console.ReadLine();

//parse la chaine de caractère "N" en un entier 
//"Rayon"
int Rayon = int.Parse(R);

//la valeur de PI est Math.PI
//affiche sur la console "Le périmètre du cercle est : "
//et le résultat du calcul
Console.WriteLine("Le périmètre du cercle est : " + 2 * Math.PI * Rayon);

//permet de laisser la fenêtre de la console ouverte
Console.ReadLine();