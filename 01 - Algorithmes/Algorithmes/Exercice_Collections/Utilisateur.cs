using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercice_Collections
{
    public class Utilisateur
    {
        private Guid id;
        private string nom;
        private string prenom;
        private DateTime dateDeNaissance;
        private string? metier;
        private string? couleur;

        public Utilisateur()
        {

        }

        public Utilisateur(Guid id, string nom, string prenom, DateTime dateDeNaissance, string? metier, string? couleur)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.dateDeNaissance = dateDeNaissance;
            this.metier = metier;
            this.couleur = couleur;
        }

        public int GetAge()
        {
            return 0;
        }

        public bool IsMajeur()
        {
            return true;
        }

        public string GetCouleurOuMetier()
        {
            return "";
        }

        public string GetDateDeNaissance()
        {
            return "";
        }

        public string GetNomComplet()
        {
            return prenom + " " + nom;
        }
    }
}