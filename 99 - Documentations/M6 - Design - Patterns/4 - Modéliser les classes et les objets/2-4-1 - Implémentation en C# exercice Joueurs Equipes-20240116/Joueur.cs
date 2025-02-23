using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoueursEquipes
{
    public class Joueur
    {
        private string nom;

        private DateOnly dateNaissance;
        public DateOnly DateNaissance { get => dateNaissance; set => dateNaissance = value; }

        private List<Contrat> contrats = new List<Contrat>();

        public Joueur(string nom, DateOnly dateNaissance)
        {
            this.nom = nom;
            this.dateNaissance = dateNaissance;
        }

        public void ajouterContrat(Contrat contrat)
        {
            contrats.Add(contrat);
        }

        public void retirerContrat(Contrat contrat)
        {
            contrats.Remove(contrat);
        }


    }
}
