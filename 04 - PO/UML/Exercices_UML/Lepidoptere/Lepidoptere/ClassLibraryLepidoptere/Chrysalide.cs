using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryLepidoptere
{
    public class Chrysalide : StadeDEvolution
    {
        /// <summary>
        /// Constructeur
        /// </summary>
        public Chrysalide()
        { }

        /// <summary>
        /// Méthode SeDeplacer()
        /// </summary>
        public override void SeDeplacer()
        {
            Console.WriteLine("Je ne peux pas !");
        }

        /// <summary>
        /// Méthode SeDeplacer()
        /// </summary>
        /// <returns>new Papillon()</returns>
        public override StadeDEvolution SeMetamorphoser()
        {
            return new Papillon();
        }
    }
}