using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementationVille
{
    public class Pays
    {
        /// <summary>
        /// Le nom du pays
        /// </summary>
        private string nom {get;set;}

        private List<Ville> villes = new List<Ville>();

        /// <summary>
        /// Ajout d'une ville au pays
        /// </summary>
        /// <param name="ville"></param>
        public void ajouterVille(Ville ville)
        {
            ville.Pays = this;
            villes.Add(ville);
        }

        public void retirerVille(Ville ville)
        {
            ville.Pays = null;
            villes.Remove(ville);
        }

    }
}
