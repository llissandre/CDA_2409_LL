using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPObjet
{
    /// <summary>
    /// Représente une Entreprise
    /// </summary>
    internal class Entreprise
    {
        /// <summary>
        /// Numéro d'identification
        /// </summary>
        public string Siret {get; private set;}

        /// <summary>
        /// Constructeur de l'entreprise
        /// </summary>
        /// <param name="siret">Numéro d'identification</param>
        public Entreprise(string siret)
        {
            Siret = siret;
        }

        /// <summary>
        /// Permet de récupérer une chaîne de caractères qui comprends
        /// les informations d'identification de l'entreprise
        /// </summary>
        /// <returns>Informations d'identification</returns>
        public string AfficherIdentite()
        {
            return $"L'entreprise N° {Siret} :";
        }

       
    }
}
