using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryLepidoptere
{
    public class Chenille : StadeDEvolution
    {
        /// <summary>
        /// Constructeur
        /// </summary>
        public Chenille()
        { }

        /// <summary>
        /// Méthode SeDeplacer()
        /// </summary>
        public override void SeDeplacer()
        {
            Console.WriteLine("Je rampe !");
        }

        /// <summary>
        /// Méthode SeMetamorphoser()
        /// </summary>
        /// <returns>new Chrysalide()</returns>
        public override StadeDEvolution SeMetamorphoser()
        {
            return new Chrysalide();
        }
    }
}