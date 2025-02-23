// See https://aka.ms/new-console-template for more information

using TP_Point;
using TP_Cercle;

Cercle cercle = new Cercle();
cercle.Afficher();

Console.WriteLine("Chercher un point :");
Console.WriteLine("Point abscisse: ");
double abscisse = double.Parse(Console.ReadLine());
Console.WriteLine("Point ordonée: ");
double ordonee = double.Parse(Console.ReadLine());

if(cercle.Appartient(new Point(abscisse, ordonee))) {
    Console.WriteLine("Le point appartient au cercle");
}
else
{
    Console.WriteLine("Le point n'appartient pas au cercle");
}