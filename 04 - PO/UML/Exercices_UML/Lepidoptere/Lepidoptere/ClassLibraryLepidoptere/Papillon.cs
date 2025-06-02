using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryLepidoptere
{
    public class Papillon : StadeDEvolution
    {
        /// <summary>
        /// Constructeur
        /// </summary>
        public Papillon()
        { }


        /// <summary>
        /// Méthode SeDeplacer()
        /// </summary>
        public override void SeDeplacer()
        {
            Console.WriteLine("Je vole !");
        }

        /// <summary>
        /// Méthode SeMetamorphoser()
        /// </summary>
        /// <returns>this</returns>
        public override StadeDEvolution SeMetamorphoser()
        {
            return this;
        }
    }
}