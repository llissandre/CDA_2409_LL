using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambdas
{
    public class Voiture : IComparable<Voiture> 
    {
        public String Couleur { get; set; }
        public String Marque { get; set; }
        public int Vitesse { get; set; }

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Voiture()
        {
            Couleur = "Blanc";
            Vitesse = 30;
            Marque = "Lada";
        }

        public override string ToString()
        {
            return $"Couleur = {Couleur}, Marque={Marque}, Vitesse={Vitesse} ";
        }

        //Méthode imposée par l'interface IComparable<T>
        //Une voiture ne peut être comparée qu'avec une autre voiture
        public int CompareTo(Voiture other)
        {
            return this.Vitesse.CompareTo(other.Vitesse);
        }
    }
}
