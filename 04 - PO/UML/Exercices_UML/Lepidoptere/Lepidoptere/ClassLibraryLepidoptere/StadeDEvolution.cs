using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryLepidoptere
{
    public abstract class StadeDEvolution
    {
        /// <summary>
        /// Constructeur
        /// </summary>
        public StadeDEvolution(){}

        /// <summary>
        /// Destructeur
        /// </summary>
        ~StadeDEvolution(){}

        /// <summary>
        /// Méthode abstraite SeDeplacer() de type void
        /// </summary>
        public abstract void SeDeplacer();

        /// <summary>
        /// Méthode abstraite SeMetamorphoser() de type StadeDEvolution
        /// </summary>
        /// <returns></returns>
        public abstract StadeDEvolution SeMetamorphoser();
    }
}