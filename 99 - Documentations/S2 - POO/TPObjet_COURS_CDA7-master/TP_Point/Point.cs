using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Point;

internal class Point
{
    /// <summary>
    /// Point sur l'Abscisse
    /// </summary>
    public float Abscisse { get; private set; }

    /// <summary>
    /// Point sur l'Ordonne
    /// </summary>
    public float Ordonne { get; private set; }

    /// <summary>
    /// Constructeur d'un point
    /// </summary>
    /// <param name="abscisse">Point sur l'Abscisse</param>
    /// <param name="ordonne">Point sur l'Ordonne</param>
    public Point(float abscisse, float ordonne)
    {
        Abscisse = abscisse;
        Ordonne = ordonne;
        
    }

    /// <summary>
    /// Calculer la Norme du vecteur {(0,0), (abscisse, ordonnee)}
    /// </summary>
    /// <returns>Retourne la norme</returns>
    public double Norme()
    {
        //Sqrt(x^2 + y^2)
        return  Math.Sqrt(Math.Pow(Abscisse,2) + Math.Pow(Ordonne, 2));
    }

}
