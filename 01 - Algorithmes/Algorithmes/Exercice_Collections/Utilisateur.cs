using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercice_Collections
{
    public class Utilisateur
    {
        // variables
        //private Guid id;
        private string nom;
        private string prenom;
        private DateTime dateDeNaissance;
        private string? metier;
        private string? couleurPreferee;

        public Utilisateur()
        {

        }

        public Utilisateur(string _nomPrenom, string _dateDeNaissance)
        {
            string[] nomPrenomSepare = _nomPrenom.Split(' ');
            this.nom = nomPrenomSepare[0];
            this.prenom = nomPrenomSepare[1];

            if (!DateTime.TryParse(_dateDeNaissance, out dateDeNaissance))
            {
                throw new ArgumentException("Date de naissance invalide !");
            }

            if (dateDeNaissance > DateTime.Now)
            {
                throw new ArgumentException("Date de naissance invalide !");
            }
        }

        public void SetMetier(string _valeur)
        {
            this.metier = _valeur;
        }

        public void SetCouleurPreferee(string _valeur)
        {
            this.couleurPreferee = _valeur;
        }

        public string GetNomComplet()
        {
            return nom + " " + prenom;
        }

        public string GetDateDeNaissance()
        {
            return "";
        }

        public int GetAge()
        {
            TimeSpan intervalle = DateTime.Now - dateDeNaissance;
            return (int)(intervalle.Days / 365.25);
        }

        public bool IsMajeur()
        {
            //int age = this.GetAge();
            //return age > 18;

            return this.GetAge() > 18;
        }

        public string? GetCouleurOuMetier()
        {
            return this.IsMajeur() ? this.metier : this.couleurPreferee;
        }
    }
}