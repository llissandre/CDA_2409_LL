using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_LINQ
{
    /// <summary>
    /// Classe voiture
    /// </summary>
    public class Voiture
    {
        private String immatriculation;
        private String couleur;
        private int kilometrage;

        public string Immatriculation { get => immatriculation; }
        public string Couleur { get => couleur; }
        public int Kilometrage { get => kilometrage;  }

        public Voiture(string immatriculation, string couleur, int kilometrage)
        {
            this.immatriculation = immatriculation;
            this.couleur = couleur;
            this.kilometrage = kilometrage;
        }

        public override string? ToString()
        {
            return $"{immatriculation} {couleur} KM={kilometrage}";
        }
    }
}
