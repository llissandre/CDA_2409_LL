using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Livre
{
    /// <summary>
    /// Représente un Livre
    /// </summary>
    internal class Livre
    {
        //CLASSE
        /// <summary>
        /// Compteur d'instance de livre
        /// </summary>
        public static int CompteurDidentifiant = 1;

        //INSTANCE
        /// <summary>
        /// Identifiant du livre
        /// </summary>
        public int IdLivre{get; private set;}

        /// <summary>
        /// Titre du livre
        /// </summary>
        public string Titre { get; private set; }

        /// <summary>
        /// Nom complet de l'auteur
        /// </summary>
        public string Auteur { get; private set; }

        /// <summary>
        /// Prix du livre
        /// </summary>
        public float Prix { get; private set; }

        public Livre()
        {
            IdLivre = CompteurDidentifiant;
            Console.WriteLine($"Livre {IdLivre} :");
            Console.WriteLine("Donner le titre :");
            Titre = Console.ReadLine().Trim();

            Console.WriteLine("Donner l'auteur :");
            Auteur = Console.ReadLine().Trim();

            Console.WriteLine("Donner le prix :");
            try
            {
                Prix = float.Parse(Console.ReadLine().Trim());

            }catch(Exception e)
            {
                Prix = 0;
            }
            CompteurDidentifiant += 1;
        }

        public Livre(string titre, string auteur, float prix)
        {
            IdLivre = CompteurDidentifiant;

            Titre = titre;
            Auteur = auteur;
            Prix = prix;
            CompteurDidentifiant += 1;
        }


        public void Afficher()
        {
            Console.WriteLine(@$"
------------------------------------
Le titre du livre est ({Titre})
L'auteur du livre est ({Auteur})
Le prix est de ({Prix}) euros
------------------------------------");
        }

    }
}
