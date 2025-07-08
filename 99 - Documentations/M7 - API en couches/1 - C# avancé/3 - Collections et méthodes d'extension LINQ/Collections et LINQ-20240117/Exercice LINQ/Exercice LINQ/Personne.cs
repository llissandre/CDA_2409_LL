using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_LINQ
{
    /// <summary>
    /// Classe Personne
    /// </summary>
    public class Personne
    {
        private String nom;
        public string Nom { get => nom; }

        private String prenom;
        public string Prenom { get => prenom; }

        public Sexe Sexe { get => sexe; }
        private Sexe sexe;

        private DateTime dateNaissance;
        public DateTime DateNaissance { get => dateNaissance; }
        public int Age //Propriété calculée
        {
            get
            {
                int age = (DateTime.Today - DateNaissance).Days / 365;
                return age;
            }
        }
        //Les voitures de la personne
        private List<Voiture> voitures = new List<Voiture>();
        public IEnumerable<Voiture> Voitures { get => voitures; }

        public Personne(string nom, string prenom, Sexe sexe, DateTime dateNaissance)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.sexe = sexe;
            this.dateNaissance = dateNaissance;
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return $"{nom} {prenom} {sexe} {dateNaissance.ToShortDateString()} --> {String.Join(",", voitures)}";
        }

        public void AjouterVoiture(Voiture voiture)
        {
            voitures.Add(voiture);
        }

        public bool EstMajeur()
        {
            return (Age >= 18);
        }


    }
}
