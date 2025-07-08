using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Point;

namespace TP_Cercle;

internal class Cercle
{

    /// <summary>
    /// Centre du cercle
    /// </summary>
    public Point Centre {get; private set;}

    /// <summary>
    /// Rayon du cercle
    /// </summary>
    public double Rayon {get; private set;}


    public Cercle()
    {
        double  abscisse;
        double  ordonne;
        Console.WriteLine("Donner l'abscisse du centre :");
        abscisse = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Donner l'ordonnée du centre :");
        ordonne = double.Parse(Console.ReadLine());

        Centre = new Point(abscisse, ordonne);
        
        Console.WriteLine("Donner le rayon du cercle :");
        Rayon = double.Parse(Console.ReadLine());
    }

    public Cercle(Point centre, double rayon)
    {
        Centre = centre;
        Rayon = rayon;
    }


    public double GetPerimetre()
    {
        return Math.PI * Rayon;
    }

    public double GetSurface()
    {
        return Math.PI * Math.Pow(Rayon, 2);
    }

    public bool Appartient(Point searchPoint)
    {
        double distanceAbscisse = Math.Sqrt(
            Math.Pow((searchPoint.Abscisse - Centre.Abscisse ), 2)); 

        double distanceOrdonee = Math.Sqrt(
            Math.Pow((searchPoint.Ordonne - Centre.Ordonne ), 2)); 
        
        return distanceAbscisse <= Rayon && distanceOrdonee <= Rayon;
    }

    public void Afficher()
    {
        Console.WriteLine($"CERCLE({Centre.Abscisse},{Centre.Ordonne},{Rayon})");
        Console.WriteLine($"Le périmètre du cercle est de : {Math.Round(GetPerimetre(),2)} cm");
        Console.WriteLine($"La surface du cercle est de : {Math.Round(GetSurface(), 2)} cm²");
   
     }
}
