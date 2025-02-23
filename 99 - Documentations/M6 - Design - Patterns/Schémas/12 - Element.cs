using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemeFichier_CDA07.Elements
{
    /// <summary>
    /// INterface des éléments référençable par un lien
    /// </summary>
    public interface Referencable
    {

    }

    /// <summary>
    /// Classe Element (tout élément du système de fichier)
    /// </summary>
    public abstract class Element
    {
        // nom de l'élément
        private string? nom;

        // dossier parent
        private Dossier? dossierParent;

        public string Nom { get => nom; set => nom = value; }
        public Dossier DossierParent { get => dossierParent; set => dossierParent = value; }

        protected Element()
        {
        }

        protected Element(string nom, Dossier dossierParent)
        {
            this.nom = nom;
            this.dossierParent = dossierParent;
        }

        // Méthode pour obteir la taille de l'élément
        public abstract int getTaille();
    }

    public class Dossier : Element, Referencable
    {
        /// <summary>
        /// Elements contenus dans le dossier
        /// </summary>
        private List<Element> contenu;

        public Dossier() : this(null, null)
        {
        }

        public Dossier(string nom, Dossier dossierParent): base(nom, dossierParent) 
        {            
            contenu = new List<Element>();
        }


        public override int getTaille()
        {
            int taille = 0;
            foreach (Element element in contenu)
            {
                taille += element.getTaille();
            }
            return taille;
        }

        public void ajouterElement(Element e)
        {
            contenu.Add(e);
        }

        public void retirerElement(Element e)
        {
            contenu.Remove(e);
        }
    }

    /// <summary>
    /// Classe Fichier
    /// </summary>
    public class Fichier : Element, Referencable
    {
        private int taille = 0;

        public int Taille {set => taille = value; }

        public Fichier()
        {
        }

        public override int getTaille()
        {
            return taille;
        }

    }

    public class Lien : Element
    {
        private Referencable reference;

        public Referencable Reference { get => reference; set => reference = value; }

        public override int getTaille()
        {
            return 0;
        }
    }



 }
