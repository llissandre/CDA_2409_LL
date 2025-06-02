using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryLepidoptere
{
    public class Oeuf : StadeDEvolution
    {
        /// <summary>
        /// Constructeur
        /// </summary>
        public Oeuf()
        { }
        
        /// <summary>
        /// Méthode SeDeplacer()
        /// </summary>
        public override void SeDeplacer()
        {
            Console.WriteLine("Je ne peux pas !");
        }

        /// <summary>
        /// Méthode SeMetamorphoser()
        /// </summary>
        /// <returns>new Chenille()</returns>
        public override StadeDEvolution? SeMetamorphoser()
        {
            return new Chenille();
        }
    }
}